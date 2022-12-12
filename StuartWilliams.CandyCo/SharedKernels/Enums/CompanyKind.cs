﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Kind: Company
    /// </summary>
    [Flags]
    public enum CompanyKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Vendor
        /// </summary>
        Vendor = 1,
        /// <summary>
        /// Customers
        /// </summary>
        Customer = 2,
        /// <summary>
        /// Other
        /// </summary>
        Other = 4,
    }
}
