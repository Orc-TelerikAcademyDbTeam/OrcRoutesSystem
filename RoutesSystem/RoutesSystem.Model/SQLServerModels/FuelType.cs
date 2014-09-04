namespace RoutesSystem.Model.SQLServerModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class FuelType
    {
        public FuelType()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
