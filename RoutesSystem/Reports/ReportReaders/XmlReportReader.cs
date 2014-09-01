namespace RoutesSystem.Core.Reports
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Xml;


    public class XmlReportReader<T>
    {
        private string filePath;
        private XmlDocument document;

        public XmlReportReader(string filePath)
        {
            this.FilePath = filePath;
        }

        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        public XmlDocument Document
        {
            get
            {
                if (this.document == null)
                {
                    this.document = new XmlDocument();
                    this.document.Load(this.FilePath);
                }

                return this.document;
            }

            set { this.document = value; }
        }

        public T ReadDocument(string modelsNamespace)
        {
            T document = (T)Activator.CreateInstance(typeof(T));
            XmlElement rootNode = this.Document.DocumentElement;

            foreach (XmlElement node in rootNode.ChildNodes)
            {
                ParseNode(node, document, modelsNamespace);
            }

            return document;
        }

        private void ParseNode(XmlElement masterNode, object modelElement, string modelsNamespace)
        {
            var modelClassName = TypeToUpper(masterNode.Name);
            var fullTypePath = modelsNamespace + "." + modelClassName;
            Type objectType = Type.GetType(fullTypePath, true);
            var currentModel = Activator.CreateInstance(objectType);

            foreach (XmlAttribute attribute in masterNode.Attributes)
            {
                PropertyInfo modelProperty = currentModel.GetType().GetProperties().FirstOrDefault(p => p.Name == TypeToUpper(attribute.Name));
                if (modelProperty == null)
                {
                    throw new NotImplementedException("The model of the model type is missing property that is added to the xml!");
                }

                Type proptyType = modelProperty.PropertyType;
                dynamic propertyValue;
                Type dataType = attribute.Value.GetType();
                if (proptyType != dataType)
                {
                    object[] parameters = new object[] { attribute.Value };
                    propertyValue = proptyType.InvokeMember("Parse", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, parameters);
                }
                else
                {
                    propertyValue = attribute.Value;
                }

                modelProperty.SetValue(currentModel, propertyValue);
            }

            foreach (dynamic node in masterNode.ChildNodes)
            {
                if ((node as XmlElement) != null)
                {
                    ParseNode(node, currentModel, modelsNamespace);
                }
            }

            var method = modelElement.GetType().GetMethods().FirstOrDefault(m => m.Name == "Add" + modelClassName);
            method.Invoke(modelElement, new object[] { currentModel });
        }

        private object ChangeType(object value, Type proptyType)
        {
            try
            {
                return Convert.ChangeType(value, proptyType);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return new object();
        }

        private string TypeToUpper(string typeName)
        {
            var letters = typeName.ToCharArray();
            letters[0] = letters[0].ToString().ToUpperInvariant()[0];
            return new string(letters);
        }
    }
}
