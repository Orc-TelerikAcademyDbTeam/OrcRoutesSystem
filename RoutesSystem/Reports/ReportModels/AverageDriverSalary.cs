namespace Reports.ReportModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AverageDriverSalary
    {
        public string DriverFirstName { get; set; }

        public string DriverLastName { get; set; }

        public decimal SalarySum { get; set; }

        public int SalariesCount { get; set; }

        public decimal AverageSalary
        {
            get
            {
                return this.SalarySum / this.SalariesCount;
            }
        }
    }
}
