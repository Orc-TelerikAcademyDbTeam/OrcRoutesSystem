namespace Reports.ReportModels
{
    using System.Collections;
    using System.Collections.Generic;

    public class CarTechnicalExpensesReport : IEnumerable<CarEntry>
    {
        private ICollection<CarEntry> carEntries;

        public CarTechnicalExpensesReport()
        {
            this.CarEntries = new List<CarEntry>();
        }

        public ICollection<CarEntry> CarEntries
        {
            get 
            {
                return this.carEntries; 
            }

            set 
            { 
                this.carEntries = value; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<CarEntry> GetEnumerator()
        {
            foreach (var car in this.CarEntries)
            {
                yield return car;
            }
        }

        public void AddCarEntry(CarEntry car)
        {
            this.CarEntries.Add(car);
        }
    }
}
