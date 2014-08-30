namespace RoutesSystem.Model
{
    using System.Collections.Generic;

    public class Route
    {
        public Route()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }

        public int StartTown { get; set; }

        public int EndTown { get; set; }

        public virtual Town Town { get; set; }

        public float Distance { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}