namespace Reports.ReportModels
{
    using System.Collections.Generic;

    internal class VisitedRouteInfo
    {
        public string StartTownName { get; set; }

        public string EndTownName { get; set; }

        internal IEnumerable<VehicleRouteInfo> VehicleRouteInfo { get; set; }
    }
}
