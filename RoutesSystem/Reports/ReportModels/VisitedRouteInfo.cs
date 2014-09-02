namespace Reports.ReportModels
{
    using System.Collections.Generic;

    internal class VisitedRouteInfo
    {
        internal string StartTownName { get; set; }

        internal string EndTownName { get; set; }

        internal double Distance { get; set; }

        internal IEnumerable<VehicleRouteInfo> VehicleRouteInfo { get; set; }
    }
}
