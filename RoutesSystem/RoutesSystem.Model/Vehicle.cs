namespace RoutesSystem.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Vehicle
    {
        public int Id { get; set; }

        //public int DriverId { get; set; }

        //public virtual Driver Driver { get; set; }

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
        
    }
}
