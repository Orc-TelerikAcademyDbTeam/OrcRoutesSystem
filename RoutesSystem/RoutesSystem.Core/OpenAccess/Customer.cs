namespace RoutesSystem.Core.OpenAccess
{
    using System;
    using System.Linq;

    public class Customer
    {
       public int ID { get; set; }
       public string Name { get; set; }
       public DateTime DateCreated { get; set; }
       public string EmailAddress { get; set; }
    }
}