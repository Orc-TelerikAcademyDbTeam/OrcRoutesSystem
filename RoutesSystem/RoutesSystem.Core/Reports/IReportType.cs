using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Core
{
    public interface IReportType
    {
        string Title { get; set; }
        string Content { get; set; }

        void WriteToFile();
    }
}
