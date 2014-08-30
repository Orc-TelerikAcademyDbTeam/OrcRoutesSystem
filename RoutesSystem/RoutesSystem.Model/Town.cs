namespace RoutesSystem.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public class Town
    {
        public Town()
        {
            this.Routes = new HashSet<Route>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Route> Routes { get; set; }
    }
}