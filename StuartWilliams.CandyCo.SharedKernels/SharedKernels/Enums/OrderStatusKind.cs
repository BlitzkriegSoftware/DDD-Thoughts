using System;

namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Kind: Order Status
    /// </summary>
    [Flags]
    public enum OrderStatusKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Draft
        /// </summary>
        Draft = 1,

        /// <summary>
        /// Approved to send
        /// </summary>
        Approved = 2,

        /// <summary>
        /// Sent to Vendor
        /// </summary>
        Sent = 4,

        /// <summary>
        /// Accepted by Vendor
        /// </summary>
        VendorAccepted = 8,

        /// <summary>
        /// Rejected by Vendor
        /// </summary>
        VendorRejected = 16,

        /// <summary>
        /// Cancelled by us
        /// </summary>
        Cancelled = 32,

        /// <summary>
        /// Fullfilled
        /// </summary>
        Fullfilled = 64,

        /// <summary>
        /// Problem
        /// </summary>
        Problem = 256,

        /// <summary>
        /// Partially filled
        /// </summary>
        Partial = 512,

    }
}
