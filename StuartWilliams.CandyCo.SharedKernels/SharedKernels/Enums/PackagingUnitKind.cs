using System;

namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Packaging Unit Kind
    /// </summary>
    [Flags]
    public enum PackagingUnitKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// One each
        /// </summary>
        Each = 1,

        /// <summary>
        /// Comes in a container of N
        /// </summary>
        ContainerOfN = 2,

        /// <summary>
        /// Both
        /// </summary>
        Both = PackagingUnitKind.Unknown |
               PackagingUnitKind.Each | 
               PackagingUnitKind.ContainerOfN

    }
}
