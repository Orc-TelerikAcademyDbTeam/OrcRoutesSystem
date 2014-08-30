namespace RoutesSystem.Model
{
    using System.ComponentModel.DataAnnotations;

    public class Driver
    {
        public Driver()
        {
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string LastName { get; set; }
    }
}