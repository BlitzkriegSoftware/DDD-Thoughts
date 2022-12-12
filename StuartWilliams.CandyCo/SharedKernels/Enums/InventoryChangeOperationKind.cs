namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Inventory Change Operation Kind
    /// </summary>
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
        InventoryLossMissing = 3,
        /// <summary>
        /// Inventory Loss Damaged
        /// </summary>
        InventoryLossDamaged = 4,
        /// <summary>
        /// Inventory Transfer
        /// </summary>
        InventoryTransfer = 5,
        /// <summary>
        /// Inventory Return From Customer
        /// </summary>
        InventoryReturnFromCustomer = 6,
        /// <summary>
        /// Inventory Return To Vendor
        /// </summary>
        InventoryReturnToVendor = 7

    }
}
