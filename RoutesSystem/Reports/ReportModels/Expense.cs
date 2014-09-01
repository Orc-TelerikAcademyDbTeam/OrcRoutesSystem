namespace Reports.ReportModels
{
    using System;

    public class Expense
    {
        private DateTime month;

        private decimal cost;

        public decimal Cost
        {
            get { return this.cost; }
            set { this.cost = value; }
        }

        public DateTime Month
        {
            get { return this.month; }
            set { this.month = value; }
        }
    }
}
