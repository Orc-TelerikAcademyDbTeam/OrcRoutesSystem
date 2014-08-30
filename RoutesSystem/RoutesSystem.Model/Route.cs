namespace RoutesSystem.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Route
    {
        public Route()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }

        public int Id { get; set; }

        [Required]
        [ForeignKey("Town")]
        public int StartTownId { get; set; }

        [Required]
        [ForeignKey("Town")]
        public int EndTownId { get; set; }

        public virtual Town Town { get; set; }

        [Required]
        public float Distance { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}