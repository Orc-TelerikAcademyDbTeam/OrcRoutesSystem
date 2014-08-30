namespace RoutesSystem.Model
{
    using System;
    using System.Collections.Generic;

    public class FuelType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
