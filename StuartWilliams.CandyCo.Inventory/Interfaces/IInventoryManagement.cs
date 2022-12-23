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
        /// Transfer
        /// </summary>
        /// <param name="order">InventoryTransferOrder</param>
        /// <param name="errors">(sic)</param>
        /// <returns>True on success</returns>
        bool Transfer(InventoryTransferOrder order, out IEnumerable<CandyCoError> errors);

        /// <summary>
        /// Received
        /// </summary>
        /// <param name="order">InventoryTransferOrder</param>
        /// <param name="errors">(sic)</param>
        /// <returns>True on success</returns>
        bool Received(InventoryTransferOrder order, out IEnumerable<CandyCoError> errors);

        /// <summary>
        /// Sold
        /// </summary>
        /// <param name="order">InventoryTransferOrder</param>
        /// <param name="errors">(sic)</param>
        /// <returns>True on success</returns>
        bool Sold(InventoryTransferOrder order, out IEnumerable<CandyCoError> errors);

        /// <summary>
        /// Lost
        /// </summary>
        /// <param name="order">InventoryTransferOrder</param>
        /// <param name="errors">(sic)</param>
        /// <returns>True on success</returns>
        bool Lost(InventoryTransferOrder order, out IEnumerable<CandyCoError> errors);

        /// <summary>
        /// Returned
        /// </summary>
        /// <param name="order">InventoryTransferOrder</param>
        /// <param name="errors">(sic)</param>
        /// <returns>True on success</returns>
        bool Returned(InventoryTransferOrder order, out IEnumerable<CandyCoError> errors);

    }
}