using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;

namespace StuartWilliams.CandyCo.Sales.Interfaces
{
    /// <summary>
    /// Interface: Sales Order Management
    /// </summary>
    public interface ISalesOrderManagement : ICrud
    {
        /// <summary>
        /// Update: Purchase Order (PO) Status
        /// </summary>
        /// <param name="orderId">(sic)</param>
        /// <param name="status">OrderStatusKind</param>
        /// <returns>True if so</returns>
        bool UpdateSalesOrderStatus(long orderId, OrderStatusKind status);

        /// <summary>
        /// Get: Purchase Order (PO) Status
        /// </summary>
        /// <param name="orderId">(sic)</param>
        /// <returns>OrderStatusKind</returns>
        OrderStatusKind SalesOrderStatus(long orderId);

    }
}