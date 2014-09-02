using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQL
{
     public class Report
    {
       public int ID { get; set; }
       public string DriverName { get; set; }
       public DateTime DateCreated { get; set; }
       public string Route { get; set; }
    }
}
