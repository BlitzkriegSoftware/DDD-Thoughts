namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Kind: Logistics Center
    /// </summary>
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
        Shipper = 3,

        /// <summary>
        /// Vendor Direct aka Drop-Ship
        /// </summary>
        Vendor = 4,

        /// <summary>
        /// Any Third Party not in above
        /// </summary>
        ThirdParty = 5

    }
}
