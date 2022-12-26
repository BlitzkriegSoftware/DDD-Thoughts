using System;

using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Models;

namespace StuartWilliams.CandyCo.Procurement.Models
{
    /// <summary>
    /// Result: Product Search
    /// </summary>
    public class ProductSearchResult
    {

        /// <summary>
        /// PK (Company) of Vendor
        /// </summary>
        public long VendorId { get; set; }

        /// <summary>
        /// UPC
        /// </summary>
        public UniversalProductCode UPC { get; set; }

        /// <summary>
        /// Quoted (Vendor) Price For This Product Per <c>Container</c>
        /// </summary>
        public Money QuotedPrice { get; set; }

        /// <summary>
        /// Container
        /// </summary>
        public ContainerKind Container { get; set; }

        /// <summary>
        /// Quantity Can Be Supplied
        /// </summary>
        public int QuantityCanBeSupplied { get; set; }

        /// <summary>
        /// Deliverable By TimeStamp
        /// </summary>
        public DateTime DeliverableByTimeStamp { get; set; }
    }
}
