using System;

namespace StuartWilliams.CandyCo.SharedKernels.Enums
{

    /// <summary>
    /// Container Type
    /// </summary>
    [Flags]
    public enum ContainerKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Each
        /// </summary>
        Each = 1,

        /// <summary>
        /// Box
        /// </summary>
        Box = 2,

        /// <summary>
        /// Pallet
        /// </summary>
        Pallet = 4,

        /// <summary>
        /// Drum
        /// </summary>
        Drum = 8,

        /// <summary>
        /// Bag
        /// </summary>
        Bag = 16,

        /// <summary>
        /// Any
        /// </summary>
        Any = ContainerKind.Unknown | 
              ContainerKind.Each | 
              ContainerKind.Box | 
              ContainerKind.Pallet | 
              ContainerKind.Drum | 
              ContainerKind.Bag

    }
}
