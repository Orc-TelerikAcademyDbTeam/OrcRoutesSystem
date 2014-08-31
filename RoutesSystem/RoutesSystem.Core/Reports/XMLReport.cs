namespace RoutesSystem.Core.Reports
{
    using System;
    using System.Xml;

    public class XMLReport : IReportFileType
    {
        public XMLReport(string title)
        {
            this.Title = title;
        }

        public string Title { get; set; }

        public void CreateReport(IReportData data)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create("d:\\Report.xml", settings))
            {
                writer.WriteStartDocument();
                writer.WriteComment(Title);
                writer.WriteStartElement("Route1");
                writer.WriteAttributeString("Name", "RouteName");

                writer.WriteElementString("test", "test");//this should be a loop with all the data

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }
    }
}