using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoutesSystem.Data;
using RoutesSystem.Model;

namespace RouteSystemUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            var data = new RoutesSystemDbContext();

            data.Manufacturers.Add(new Manufacturer
            {
                Name = "Pesho"
            });

            data.SaveChanges();

            var manufacturers = data.Manufacturers.FirstOrDefault();

            MessageBox.Show(manufacturers.Id.ToString());
        }
    }
}
