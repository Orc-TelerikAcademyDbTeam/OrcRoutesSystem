using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Model.SQLServerModels
{
    using System.Collections.ObjectModel;

    public class CarEntry
    {
        private ICollection<CarExpenses> vehicleExpenses;

        public CarEntry()
        {
            this.vehicleExpenses=new Collection<CarExpenses>();
        }
        public int Id { get; set; }

        public virtual ICollection<CarExpenses> VehicleExpenses
        {
            get
            {
                return this.vehicleExpenses;
            }
            set
            {
                this.vehicleExpenses = value;
            }
        }
    }
}
