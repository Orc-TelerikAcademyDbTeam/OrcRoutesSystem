namespace RoutesSystem.Model.SQLServerModels
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Route
    {
        public Route()
        {
            this.VehicleRoutes = new HashSet<VehicleRoute>();
        }

        public int Id { get; set; }

        [Required]
        public int StartTownId { get; set; }

        public virtual Town StartTown { get; set; }

        [Required]
        public int EndTownId { get; set; }

        public virtual Town EndTown { get; set; }

        [Required]
        public float Distance { get; set; }

        public virtual ICollection<VehicleRoute> VehicleRoutes { get; set; }
    }
}