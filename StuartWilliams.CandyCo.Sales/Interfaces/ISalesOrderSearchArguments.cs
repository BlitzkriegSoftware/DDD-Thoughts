using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;

namespace StuartWilliams.CandyCo.Sales.Interfaces
{
    /// <summary>
    /// Interface: Sales Order Search
    /// </summary>
    public interface ISalesOrderSearchArguments : ISearchArgumentsBase
    {
        /// <summary>
        /// Kind: Sales Order Status
        /// </summary>
        public OrderStatusKind OrderStatus { get; set; }

        /// <summary>
        /// Sales Order Id
        /// </summary>
        public long SalesOrderId { get; set; }

    }
}