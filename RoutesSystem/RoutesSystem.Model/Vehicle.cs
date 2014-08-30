namespace RoutesSystem.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Vehicle
    {
        public Vehicle()
        {
            this.Routes = new HashSet<Route>();
        }

        public int Id { get; set; }

        [Required]
        public virtual Driver Driver { get; set; }

        [Required]
        public int VehicleTypeId { get; set; }

        public virtual VehicleType Type { get; set; }

        [Required]
        public int ManifacturerId {get;set;}

        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        public int ModelId { get; set; }

        public virtual Model Model { get; set; }

        public DateTime YearOfManifacturer { get; set; }

        [Required]
        public int FuelTypeId { get; set; }

        public virtual FuelType FuelType { get; set; }

        public virtual ICollection<Route> Routes { get; set; }
    }
}