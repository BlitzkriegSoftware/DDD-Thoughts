using System;

using StuartWilliams.CandyCo.Freight.Enums;

namespace StuartWilliams.CandyCo.Freight.Models
{
    /// <summary>
    /// EventArgs: Shipper Return
    /// </summary>
    public class ShipperEventArgs : EventArgs
    {
        public ShipperEventArgs() : base() { }
       
        /// <summary>
        /// PK: Company
        /// </summary>
        public long Shipper { get; set; }

        /// <summary>
        /// PK: Shipment
        /// </summary>
        public long ShipmentId { get; set; }

        /// <summary>
        /// TimeStamp: Event
        /// </summary>
        public DateTime EventTimeStamp { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Reason
        /// </summary>
        public string Reason { get; set; } = string.Empty;

        /// <summary>
        /// Reason Kind
        /// </summary>
        public ShipperEventKind ShipperEvent { get; set; }
    }
}
