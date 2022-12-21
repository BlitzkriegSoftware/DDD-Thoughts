using System;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Inventory Item
    /// </summary>
    public interface IInventoryItem : IEntity, ICloneable
    {

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

    }
}
