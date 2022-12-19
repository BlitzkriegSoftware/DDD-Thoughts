using System;

namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Kind: Logistics Center
    /// </summary>
    [Flags]
    public enum LogisticsCenterKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Owned by Company
        /// </summary>
        CompanyOwned = 1,

        /// <summary>
        /// Operated By, but not Owned by Company
        /// </summary>
        CompanyOperated = 2,

        /// <summary>
        /// Shipper (LC at UPS, FedEx, etc.)
        /// </summary>
        Shipper = 4,

        /// <summary>
        /// Vendor Direct aka Drop-Ship
        /// </summary>
        Vendor = 8,

        /// <summary>
        /// Any Third Party not in above
        /// </summary>
        ThirdParty = 16,

        /// <summary>
        /// Any shipping
        /// </summary>
        Any = LogisticsCenterKind.Unknown | 
              LogisticsCenterKind.CompanyOwned | 
              LogisticsCenterKind.CompanyOperated |
              LogisticsCenterKind.Shipper | 
              LogisticsCenterKind.Vendor | 
              LogisticsCenterKind.ThirdParty
    }
}
