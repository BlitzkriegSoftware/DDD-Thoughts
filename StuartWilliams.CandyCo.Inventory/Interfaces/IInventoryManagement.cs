using System.Collections.Generic;

using StuartWilliams.CandyCo.SharedKernels.Interfaces;
using StuartWilliams.CandyCo.SharedKernels.Models;

namespace StuartWilliams.CandyCo.Inventory.Interfaces
{

    /// <summary>
    /// Interface: Inventory Management
    /// </summary>
    public interface IInventoryManagement : ICrud
    {

        /// <summary>
        /// ChangeInventory
        /// </summary>
        /// <param name="order">InventoryTransferOrder</param>
        /// <param name="errors">(sic)</param>
        /// <returns>True on success</returns>
        bool ChangeInventory(InventoryChangeOrder order, out IEnumerable<CandyCoError> errors);

    }
}