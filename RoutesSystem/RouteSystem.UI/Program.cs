namespace RouteSystem.UI
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using RoutesSystem.Data.DBContexts;
    using RoutesSystem.Model;
    using RoutesSystem.Model.SQLServerModels;

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new RoutesSystemForm());

            //var pdfGenerator = new PdfReportEngine();
            
            //var data = new SQLServerContext();
            //pdfGenerator.CreateReport();
            //data.Manufacturers.Add(new Manufacturer { Name = "Pesho" });

            //data.SaveChanges();

            //var jsonGen = new JSONReportWriter();
            //jsonGen.CreateReport();

            //var manufacturers = data.Manufacturers.FirstOrDefault();

            //MessageBox.Show(manufacturers.Id.ToString());

            ////ArchiveReports usage example
            //var archiveLocation = "../../../ZipArchives/Sample-Sales-Reports.zip";
            //var reportsExtensions = new HashSet<string>() { ".xls" };
            //var reportsArchive = new ReportsArchive(archiveLocation, reportsExtensions);

            //using (reportsArchive)
            //{
            //    foreach (var report in reportsArchive)
            //    {
            //        //Console.WriteLine("{0} => {1}  {2}", report.DirectoryName, report.FileName, report.FileExtension);
            //    }
            //}
        }
    }
}