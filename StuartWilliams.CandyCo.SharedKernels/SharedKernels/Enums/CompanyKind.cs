using System;

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

        /// <summary>
        /// Any
        /// </summary>
        Any = CompanyKind.Unknown | 
              CompanyKind.Vendor | 
              CompanyKind.Customer | 
              CompanyKind.Other
    }
}
