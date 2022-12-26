using StuartWilliams.CandyCo.Procurement.Enums;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;

namespace StuartWilliams.CandyCo.Procurement.Interfaces
{
    /// <summary>
    /// Interface: Purchase Order Search
    /// </summary>
    public interface IPurchaseOrderSearchArguments : ISearchArgumentsBase
    {
        /// <summary>
        /// Kind: Purchase Order Status
        /// </summary>
        public PurchaseOrderStatusKind PurchaseOrderStatus { get; set; }
    }
}