using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Models;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;

namespace StuartWilliams.CandyCo.Shipping
{
    /// <summary>
    /// Interface: Freight Search
    /// </summary>
    public interface IFreightSearch : ISearchBase
    {

        /// <summary>
        /// Kind: Packing Unit
        /// </summary>
        public PackagingUnitKind PackagingUnit { get; set; }
    }
}