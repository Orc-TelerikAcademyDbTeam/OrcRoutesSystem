namespace RouteSystem.UI
{
    using Reports.ReportWriters;
    using System;
    using System.Windows.Forms;

    internal static class UIEngine
    {
        private static void CreatePDFReport(string filePathInfo)
        {
            var pdfGen = new PdfReportWriter();
            var helper = new FilePathHelper(filePathInfo);
            pdfGen.CreateReport(helper.FilePath, helper.FileName);
        }

        //Should all writers implement interfaces because now we don't follow DRY principle.
        private static void CreateJSONReport(string filePathInfo)
        {
            var jsonGen = new JSONReportWriter();
            var helper = new FilePathHelper(filePathInfo);
            jsonGen.CreateReport(helper.FilePath, helper.FileName);
        }

        internal static void CreateReport(RadioButton button, string filePathInfo)
        {
            switch (button.Name)
            {
                case "CheckBoxAggregateRouteReport":
                    CreatePDFReport(filePathInfo);
                    break;
                case "CheckBoxVehicleInformationReport":
                    CreateJSONReport(filePathInfo);
                    break;
                default:
                    throw new ArgumentException("Wrong button passed!");
            }
        }
    }
}