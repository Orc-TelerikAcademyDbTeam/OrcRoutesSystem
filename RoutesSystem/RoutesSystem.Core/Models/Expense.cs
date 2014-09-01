namespace RoutesSystem.Core.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
