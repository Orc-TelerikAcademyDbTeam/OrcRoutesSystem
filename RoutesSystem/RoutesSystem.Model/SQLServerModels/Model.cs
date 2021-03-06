﻿namespace RoutesSystem.Model.SQLServerModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Model
    {
        public Model()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public float FuelConsumption { get; set; }

        public int NumberOfWheels { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
