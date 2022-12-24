using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;

namespace StuartWilliams.CandyCo.Inventory.Interfaces
{
    /// <summary>
    /// Interface: Inventory Search
    /// </summary>
    public interface IInventorySearchArguments : ISearchArgumentsBase
    {
        /// <summary>
        /// Kind: Inventory Change Operation
        /// </summary>
        InventoryChangeOperationKind ChangeOperationKind { get; set; }

        /// <summary>
        /// Kind: Inventory Status
        /// </summary>
        InventoryStatusKind StatusKind { get; set; }

        /// <summary>
        /// Kind: Logistics Center
        /// </summary>
        LogisticsCenterKind CenterKind { get; set; }
    }
}