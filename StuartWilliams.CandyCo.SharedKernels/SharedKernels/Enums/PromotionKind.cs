using System;

namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Kind: Promotion
    /// </summary>
    [Flags]
    public enum PromotionKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// A Percentage Off
        /// </summary>
        PercentOff = 1,
        /// <summary>
        /// Sale Price
        /// </summary>
        SalePrice = 2,
        /// <summary>
        /// Volume Discount
        /// </summary>
        VolumeDiscount = 4,

        /// <summary>
        /// Any
        /// </summary>
        Any = PromotionKind.Unknown |
              PromotionKind.PercentOff |
              PromotionKind.SalePrice |
              PromotionKind.VolumeDiscount
    }
}
