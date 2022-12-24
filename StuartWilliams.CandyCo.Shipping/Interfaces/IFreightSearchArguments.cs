using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Models;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;

namespace StuartWilliams.CandyCo.Freight.Interfaces
{
    /// <summary>
    /// Interface: Freight Search
    /// </summary>
    public interface IFreightSearchArguments : ISearchArgumentsBase
    {

        /// <summary>
        /// Kind: Packing Unit
        /// </summary>
        public PackagingUnitKind PackagingUnit { get; set; }

        /// <summary>
        /// Shipment Id
        /// </summary>
        public long ShipmentId { get; set; }

        /// <summary>
        /// Shipper
        /// </summary>
        public long Shipper { get; set; }

        /// <summary>
        /// Ship To
        /// </summary>
        public Location ShipTo { get; set; }

    }
}