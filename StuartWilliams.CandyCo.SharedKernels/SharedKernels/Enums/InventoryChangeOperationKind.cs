using System;

namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Inventory Change Operation Kind
    /// </summary>
    [Flags]
    public enum InventoryChangeOperationKind
    {
        /// <summary>
        /// This will result in an Error
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Inventory Inbound (Receiving from Vendor)
        /// </summary>
        InboundAdd = 1,
        /// <summary>
        /// Outbound Minus (Shipping to Customer)
        /// </summary>
        OutboundMinus = 2,
        /// <summary>
        /// Inventory Loss Missing
        /// </summary>
        InventoryLossMissing = 4,
        /// <summary>
        /// Inventory Loss Damaged
        /// </summary>
        InventoryLossDamaged = 8,
        /// <summary>
        /// Inventory Transfer
        /// </summary>
        InventoryTransfer = 16,
        /// <summary>
        /// Inventory Return From Customer
        /// </summary>
        InventoryReturnFromCustomer = 32,
        /// <summary>
        /// Inventory Return To Vendor
        /// </summary>
        InventoryReturnToVendor = 64,

        /// <summary>
        /// Any
        /// </summary>
        Any = InventoryChangeOperationKind.Unknown |
              InventoryChangeOperationKind.InboundAdd |
              InventoryChangeOperationKind.OutboundMinus |
              InventoryChangeOperationKind.InventoryLossMissing |
              InventoryChangeOperationKind.InventoryLossDamaged |
              InventoryChangeOperationKind.InventoryTransfer |
              InventoryChangeOperationKind.InventoryReturnFromCustomer |
              InventoryChangeOperationKind.InventoryReturnToVendor

    }
}
