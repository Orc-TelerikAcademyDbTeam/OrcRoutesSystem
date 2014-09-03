namespace Reports.ReportModels
{
    using System.Collections.Generic;

    public class CarEntry
    {
        private int registrationIndentifier;
        private ICollection<Expense> expenses;

        public CarEntry()
        {
            this.Expenses = new List<Expense>();
        }

        public int RegistrationIdentifier
        {
            get { return this.registrationIndentifier; }
            set { this.registrationIndentifier = value; }
        }

        public void AddExpense(Expense expense)
        {
            this.Expenses.Add(expense);
        }

        public ICollection<Expense> Expenses
        {
            get { return this.expenses; }
            set { this.expenses = value; }
        }
    }
}