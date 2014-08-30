using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new Form1());

            //var data = new RouteSystemData();

            //var towns = data.Towns.All();

            //foreach (var town in towns)
            //{
            //    Console.WriteLine(town.Name);
            //}

            //data.Courses.Add(new Town
            //{
            //    Name = "Sofia"
            //});

            //data.SaveChanges();

            //var students = data.Students.All();

            //Console.WriteLine(students.Count());
        }
    }
}
