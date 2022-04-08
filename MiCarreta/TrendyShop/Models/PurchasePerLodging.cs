﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrendyShop.Models
{
    public class PurchasePerLodging
    {
        [Key, Column(Order = 0)]
        public float Cost { get; set; }//ProductCost

        [Key, Column(Order = 1)]
        public string Name { get; set; }//ProductName

        [ForeignKey("Cost,Name")]
        public GastronomicProduct GastronomicProduct { get; set; }


        [Key, Column(Order = 2)]
        public int RoomId { get; set; }

        [Key, Column(Order = 3)]
        public DateTime Date { get; set; }

        [ForeignKey("RoomId, Date")]
        public Lodging Lodging { get; set; }

        public float Amount { get; set; }
    }
}
