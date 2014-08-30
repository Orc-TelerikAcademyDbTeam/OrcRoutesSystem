namespace RoutesSystem.Core.Reports
{
    using System;
    using System.Linq;
    using System.Xml;

    public class XMLReport : IReportType
    {
        public XMLReport(string title, string content)
        {
            this.Title = title;
            this.Content = EditContent(content);
        }
        
        public string Title { get; set; }
        public string Content { get; set; }

        private string EditContent(string text)
        {
            return text;//this should be the edit section for the text to be sent in the propoer format tp WriteToFile()
        }

        public void WriteToFile()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            XmlWriter writer = XmlWriter.Create("d:\\Report.xml", settings);
            writer.WriteStartDocument();
            writer.WriteComment(Title);
            writer.WriteStartElement("Route1");
            writer.WriteAttributeString("Name", "RouteName");
            
            writer.WriteElementString("test", "test");//this should be a loop with all the data
          
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }
    }
}
