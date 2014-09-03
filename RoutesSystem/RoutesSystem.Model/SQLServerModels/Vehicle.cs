namespace RoutesSystem.Model.SQLServerModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Vehicle
    {
        public Vehicle()
        {
            this.VehicleRoutes = new HashSet<VehicleRoute>();
        }

        public int Id { get; set; }

        public virtual Driver Driver { get; set; }

        [Required]
        public int VehicleTypeId { get; set; }

        public virtual VehicleType Type { get; set; }

        [Required]
        public int ManufacturerId { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        public int ModelId { get; set; }

        public virtual Model Model { get; set; }

        public DateTime YearOfManifacturer { get; set; }

        [Required]
        public int FuelTypeId { get; set; }

        public virtual FuelType FuelType { get; set; }

        public virtual ICollection<VehicleRoute> VehicleRoutes { get; set; }
    }
}