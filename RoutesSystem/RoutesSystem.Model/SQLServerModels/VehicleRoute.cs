﻿namespace RoutesSystem.Model.SQLServerModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class VehicleRoute
    {
        [Key, ForeignKey("Vehicle"), Column(Order = 1)]
        public int VehicleId { get; set; }

        [Key, ForeignKey("Route"), Column(Order = 0)]
        public int RouteId { get; set; }

        [Key, Column(Order = 2)]
        public DateTime Date { get; set; }

        public virtual Vehicle Vehicle { get; set; }

        public virtual Route Route { get; set; }
    }
}