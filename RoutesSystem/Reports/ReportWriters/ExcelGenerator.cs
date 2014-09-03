namespace Reports.ReportWriters
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.Office.Interop;
    using Microsoft.Office.Interop.Excel;

    using Reports.ReportModels;
    using System.Data.OleDb;

    internal class ExcelGenerator
    {
        private const string AVERAGE_DRIVER_SALARY_TABLE_NAME = "Average Driver Salary";
        private const string AVERAGE_TRAVELLED_DISTANCE_TABLE_NAME = "Average Travelled Distance";
        private string fileName;
        private string filePath;

        internal ExcelGenerator(string path, string fileName)
        {
            this.FilePath = path;
            this.FileName = fileName;
        }

        internal void Generate(IList<AverageDriverSalary> averageDriverSalary, IList<AverageTravelledDistance> averageTravelledDistance)
        {
            CreateExcelFile(this.FullPath);
            string connectionString = BuildConnectionString(this.FullPath);
            OleDbConnection connExcel = new OleDbConnection(connectionString);
            using (connExcel)
            {
                connExcel.Open();
                this.GenerateAverageDriverSalary(averageDriverSalary, connExcel);
                this.GenerateAverageTravelledDistance(averageTravelledDistance, connExcel);
            }
        }

        private void GenerateSchema(string tableName, ICollection<string> columnsNames, OleDbConnection connExcel)
        {
            var columnsWithAddedType = columnsNames.Select(x => "[" + x + "]" + " String");
            var formatedColumnNames = string.Join(", ", columnsWithAddedType);
            OleDbCommand tableCreationCommand = new OleDbCommand("CREATE TABLE [" + tableName + "](" + formatedColumnNames + ");", connExcel);
            tableCreationCommand.ExecuteNonQuery();
        }

        private void CreateExcelFile(string filePath)
        {
            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            var wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            var sheets = app.Worksheets;
            wb.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
            var newSheet = (Worksheet)sheets.get_Item(1);
            wb.SaveAs(this.FullPath);
            wb.Close();
        }

        private void GenerateAverageDriverSalary(IList<AverageDriverSalary> averageDriverSalary, OleDbConnection connExcel)
        {
            var columnsNames = new List<string>() { "Driver first name", "Driver last name", "Average salary" };
            this.GenerateSchema(AVERAGE_DRIVER_SALARY_TABLE_NAME, columnsNames, connExcel);
            var salaryReportColumns = columnsNames.Select(x => "[" + x + "]");
            var formatedSalaryReportColumns = string.Join(", ", salaryReportColumns);
            foreach (var salaryReport in averageDriverSalary)
            {
                OleDbCommand insertingAverageSalaryReportCommand = new OleDbCommand(@"INSERT INTO [" + AVERAGE_DRIVER_SALARY_TABLE_NAME + "$] (" + formatedSalaryReportColumns + ") VALUES('" + salaryReport.DriverFirstName + "', '" + salaryReport.AverageSalary + "')", connExcel);
                insertingAverageSalaryReportCommand.ExecuteNonQuery();
            }
        }

        private void GenerateAverageTravelledDistance(IList<AverageTravelledDistance> averageTravelledDistance, OleDbConnection connExcel)
        {
            var columnsNames = new List<string>() { "Vehicle model", "Manufacturer", "Average travelled distance" };
            this.GenerateSchema(AVERAGE_TRAVELLED_DISTANCE_TABLE_NAME, columnsNames, connExcel);
            var travelReportColumns = columnsNames.Select(x => "[" + x + "]");
            var formatedTravelReportColumns = string.Join(", ", travelReportColumns);
            foreach (var distanceReport in averageTravelledDistance)
            {
                OleDbCommand insertingAverageSalaryReportCommand = new OleDbCommand(@"INSERT INTO [" + AVERAGE_TRAVELLED_DISTANCE_TABLE_NAME + "$] (" + formatedTravelReportColumns + ") VALUES('" + distanceReport.VehicleModel + "', '" + distanceReport.VehicleManufacturer + "', '" + distanceReport.AverageDistance + "')", connExcel);
                insertingAverageSalaryReportCommand.ExecuteNonQuery();
            }
        }

        private static string BuildConnectionString(string filePath)
        {
            Dictionary<string, string> props = new Dictionary<string, string>();
            props["Provider"] = "Microsoft.ACE.OLEDB.12.0";
            props["Extended Properties"] = "Excel 12.0";
            props["Data Source"] = filePath;
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in props)
            {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }

        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        public string FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        }

        private string FullPath
        {
            get
            {
                return Path.GetFullPath(this.FilePath + this.FileName + ".xls");
            }
        }
    }
}
