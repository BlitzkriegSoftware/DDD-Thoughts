using System;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Inventory Item
    /// </summary>
    public interface IInventoryItem
    {
        /// <summary>
        /// PK
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// UPC
        /// </summary>
        public Models.UniversalProductCode Upc { get; set; }

        /// <summary>
        /// Vendor
        /// </summary>
        public long VendorId { get; set; }

        /// <summary>
        /// Vendors Inventory Code
        /// </summary>
        public string VendorInventoryCode { get; set; }

        /// <summary>
        /// Last Updated
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Is Valid
        /// </summary>
        /// <returns>True if so</returns>
        public bool IsValid();

        /// <summary>
        /// Is Deleted
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
