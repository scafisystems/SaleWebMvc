﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaleWebMvc.Models.Enums
{
    public enum SaleStatus: int
    {
        Peding = 0,
        Billed = 1,
        Canceled = 2
    }
}
