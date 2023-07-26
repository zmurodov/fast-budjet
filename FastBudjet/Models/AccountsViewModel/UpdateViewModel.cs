﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastBudjet.Models.AccountsViewModel
{
    public class UpdateViewModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public decimal? Balance { get; set; }

        public string? Description { get; set; }
    }
}
