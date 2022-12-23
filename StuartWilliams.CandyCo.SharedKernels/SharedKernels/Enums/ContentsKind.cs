using System;

namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Kind: Contents
    /// </summary>
    [Flags]
    public enum ContentsKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Solids
        /// </summary>
        Solid = 1,

        /// <summary>
        /// Liquid
        /// </summary>
        Liquid = 2,

        /// <summary>
        /// Gas
        /// </summary>
        Gas = 4,

        /// <summary>
        /// Fragile
        /// </summary>
        Fragile = 128,

        /// <summary>
        /// Volatile: Dangerous
        /// </summary>
        Volatile = 256

    }
}
