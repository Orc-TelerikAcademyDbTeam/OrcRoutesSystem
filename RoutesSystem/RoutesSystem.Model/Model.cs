namespace RoutesSystem.Model
{
    using System;
    using System.Collections.Generic;

    public class Model
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float FuelConsumption { get; set; }

        public int NumberOfWheels { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
