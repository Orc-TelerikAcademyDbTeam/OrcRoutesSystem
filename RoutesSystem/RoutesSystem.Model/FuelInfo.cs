﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutesSystem.Model
{
    using System.ComponentModel.DataAnnotations;

    public class FuelInfo
    {
        [Key]
        public int ID { get; set; }

        public int FuelId { get; set; }

        public int VehicleId { get; set; }

        public decimal Price { get; set; }

        public decimal Spent { get; set; }

        public decimal Total { get; set; }
    }
}
