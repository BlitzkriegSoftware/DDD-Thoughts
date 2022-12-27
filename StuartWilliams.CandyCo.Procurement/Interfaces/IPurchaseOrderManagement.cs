using StuartWilliams.CandyCo.Procurement.Models;
using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Models;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;

using System.Collections.Generic;

namespace StuartWilliams.CandyCo.Procurement.Interfaces
{
    /// <summary>
    /// Interface: Purchase Order Management
    /// </summary>
    public interface IPurchaseOrderManagement : ICrud
    {

        /// <summary>
        /// Find Vendors for a list of Products
        /// </summary>
        /// <param name="products">Find vendors that can supply these products</param>
        /// <returns></returns>
        IEnumerable<ProductSearchResult> FindVendorsForProducts(IEnumerable<ProductSearchArguments> products);

        /// <summary>
        /// Update: Purchase Order (PO) Status
        /// </summary>
        /// <param name="orderId">(sic)</param>
        /// <param name="status">PurchaseOrderStatusKind</param>
        /// <returns>True if so</returns>
        bool UpdatePurchaseOrderStatus(long orderId, OrderStatusKind status);

        /// <summary>
        /// Get: Purchase Order (PO) Status
        /// </summary>
        /// <param name="orderId">(sic)</param>
        /// <returns>PurchaseOrderStatusKind</returns>
        OrderStatusKind PurchaseOrderStatus(long orderId);

    }
}