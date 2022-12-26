using StuartWilliams.CandyCo.Procurement.Models;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;
using StuartWilliams.CandyCo.SharedKernels.Models;
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
    
    }
}