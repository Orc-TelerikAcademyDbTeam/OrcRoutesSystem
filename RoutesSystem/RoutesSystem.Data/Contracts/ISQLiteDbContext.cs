using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Data.Contracts
{
    using System.Data.Entity;

    using RoutesSystem.Model;

    interface ISQLiteDbContext:IDatabaseContext
    {
        IDbSet<DriverInfo> DriversInfo { get; set; }
    }
}
