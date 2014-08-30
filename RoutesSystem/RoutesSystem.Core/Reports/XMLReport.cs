namespace RoutesSystem.Core.Reports
{
    using System;
    public class XMLReport : IReportFileType
    {
        public void CreateReport(IReportData data)
        {
            this.Title = title;
            this.Content = EditContent(content);
        }
    }
}
