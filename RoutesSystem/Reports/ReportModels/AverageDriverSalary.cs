namespace Reports.ReportModels
{
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
