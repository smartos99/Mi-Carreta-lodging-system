﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TrendyShop.Models;

namespace TrendyShop.ViewModels
{
    public class NewProductViewModel
    {
        public GastronomicProduct GastronomicProduct { get; set; }

        [Display(Name = "Cantidad Inicial")]
        public int InitialAmount { get; set; }
    }
}
