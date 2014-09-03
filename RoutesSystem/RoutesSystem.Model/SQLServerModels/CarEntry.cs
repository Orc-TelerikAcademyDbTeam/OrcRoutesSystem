using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Model.SQLServerModels
{
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;

    public class CarEntry
    {
        private ICollection<CarExpenses> vehicleExpenses;

        public CarEntry()
        {
            this.vehicleExpenses=new Collection<CarExpenses>();
        }

        [Key]
        public int Id { get; set; }

        public int VehicleId { get; set; }

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
