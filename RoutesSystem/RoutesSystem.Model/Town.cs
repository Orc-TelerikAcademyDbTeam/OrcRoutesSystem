namespace RoutesSystem.Model
{
    using System.Collections.Generic;

    public class Town
    {
        public Town()
        {
            this.Routes = new HashSet<Route>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public virtual ICollection<Route> Routes { get; set; }
    }
}