using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoutesSystem.Data;
using RoutesSystem.Model;
using ArchiveReports;

namespace RouteSystemUI
{
    using RoutesSystem.Data.DBContexts;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new RoutesSystemForm());


           

            //var data = new RoutesSystemDbContext();

            //data.Manufacturers.Add(new Manufacturer
            //{
            //    Name = "Pesho"
            //});

            //data.SaveChanges();

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
