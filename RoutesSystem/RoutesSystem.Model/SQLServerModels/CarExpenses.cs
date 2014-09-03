using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Model.SQLServerModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CarExpenses
    {
        [Key]
        public int Id { get; set; }

        public int CarEntry { get; set; }

        public DateTime Date { get; set; }

        public decimal Cost { get; set; }
    }
}
