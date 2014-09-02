namespace RoutesSystem.Model.SQLServerModels
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Driver
    {
        [Key, ForeignKey("Vehicle")]
        public int VehicleId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }

        public virtual Vehicle Vehicle { get; set; }
    }
}