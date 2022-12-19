using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Kind: of Person
    /// </summary>
    [Flags]
    public enum PersonKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Primary
        /// </summary>
        Primary = 1,

        /// <summary>
        /// Sales
        /// </summary>
        Sales = 2,

        /// <summary>
        /// Receiving
        /// </summary>
        Receiving = 4,

        /// <summary>
        /// Carrier
        /// </summary>
        Carrier = 8,

        /// <summary>
        /// Other
        /// </summary>
        Other = 16,

        /// <summary>
        /// Any
        /// </summary>
        Any = PersonKind.Unknown |
              PersonKind.Primary |
              PersonKind.Sales |
              PersonKind.Carrier | 
              PersonKind.Other
    }
}
