namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Kind: Inventory Status
    /// </summary>
    public enum InventoryStatusKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Active, can be sold or ordered, back order ok
        /// </summary>
        Active = 1,

        /// <summary>
        /// Unavailable to be ordered, can be sold if in stock, no back order
        /// </summary>
        Unavailable = 2,

        /// <summary>
        /// Banned, not to be ordered or sold
        /// </summary>
        Banned = 4,

        /// <summary>
        /// Any
        /// </summary>
        Any = InventoryStatusKind.Unknown |
              InventoryStatusKind.Active | 
              InventoryStatusKind.Unavailable |
              InventoryStatusKind.Banned

    }
}
