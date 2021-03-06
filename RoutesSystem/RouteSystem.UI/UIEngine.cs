﻿namespace RouteSystem.UI
{
    using System;
    using System.Globalization;
    using System.Threading;
    using System.Windows.Forms;

    using Mongo;
    using Reports.ReportModels;
    using Reports.ReportWriters;
    using RoutesSystem.Core.Reports;
    using SQLServer;

    internal static class UIEngine
    {
        public static void ImportXMLToMongoAndSQLServer(string mongoConnectionString, string pathToXML)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            var xmlDoc = new XmlReportReader<CarTechnicalExpensesReport>(pathToXML);
            var technicalReport = xmlDoc.ReadDocument("Reports.ReportModels");
            var mongoWorker = new MongoWorker(mongoConnectionString);
            mongoWorker.ImportXMLCarsEntry(technicalReport);
            SQLServerWorker.ImportXMLCarExpenses(technicalReport);
        }

        public static void ImportExcelAndMongoData(string connectionString, string zipArchivePath)
        {
            SQLServerWorker.ImportMongoDBData(connectionString);
            SQLServerWorker.ImportExcellData(zipArchivePath);
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
                case "xmlReportRadio":
                    CreateXMLReport(filePathInfo);
                    break;
                case "expenseReportRadioButton":
                    CreateExcelReport(filePathInfo);
                    break;
                default:
                    throw new ArgumentException("Wrong button passed!");
            }
        }

        private static void CreatePDFReport(string filePathInfo)
        {
            var pdfGen = new PdfReportWriter();
            var helper = new FilePathHelper(filePathInfo);
            pdfGen.CreateReport(helper.FilePath, helper.FileName);
        }

        // Should all writers implement interfaces because now we don't follow DRY principle.
        private static void CreateJSONReport(string filePathInfo)
        {
            var jsonGen = new JSONReportWriter();
            var helper = new FilePathHelper(filePathInfo);
            jsonGen.CreateReport(helper.FilePath, helper.FileName);
        }

        private static void CreateXMLReport(string filePathInfo)
        {
            var xmlGen = new XmlReportWriter();
            var helper = new FilePathHelper(filePathInfo);
            xmlGen.CreateReport(helper.FilePath, helper.FileName);
        }

        private static void CreateExcelReport(string filePathInfo)
        {
            var excelGen = new ExcelReportWriter();
            var helper = new FilePathHelper(filePathInfo);
            excelGen.CreateReport(helper.FilePath, helper.FileName);
        }
    }
}