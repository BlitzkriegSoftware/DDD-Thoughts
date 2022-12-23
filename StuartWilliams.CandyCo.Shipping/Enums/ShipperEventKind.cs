using System;

namespace StuartWilliams.CandyCo.Freight.Enums
{
    /// <summary>
    /// Kind: Shipper Event
    /// </summary>
    [Flags]
    public enum ShipperEventKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Shipping Progress
        /// </summary>
        ShippingProgress = 1,

        /// <summary>
        /// Received
        /// </summary>
        Received = 2,

        /// <summary>
        /// Received
        /// </summary>
        Damaged = 4,

        /// <summary>
        /// Returned
        /// </summary>
        Returned = 8,

        /// <summary>
        /// (sic)
        /// </summary>
        ReceivedDamaged = 
            ShipperEventKind.Received |
            ShipperEventKind.Damaged,

        /// <summary>
        /// (sic)
        /// </summary>
        ReturnedDamaged =
            ShipperEventKind.Returned |
            ShipperEventKind.Damaged,
    }
}
