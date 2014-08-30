namespace RoutesSystem.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;


    public class Town
    {
        public Town()
        {
            this.StartRoutes = new HashSet<Route>();
            this.EndRoutes = new HashSet<Route>();
        }

        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Route> StartRoutes { get; set; }

        public virtual ICollection<Route> EndRoutes { get; set; }
    }
}