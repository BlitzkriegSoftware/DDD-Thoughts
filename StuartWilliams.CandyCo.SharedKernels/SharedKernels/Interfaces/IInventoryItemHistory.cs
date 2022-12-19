using System;
using System.ComponentModel.DataAnnotations;

using StuartWilliams.CandyCo.SharedKernels.Enums;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Inventory Item History
    /// </summary>
    public interface IInventoryItemHistory
    {
        /// <summary>
        /// PK
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Inventory Item
        /// </summary>
        public IInventoryItem Item { get; set; }

        /// <summary>
        /// Inventory Change Operation
        /// </summary>
        public InventoryChangeOperationKind ChangeOperationKind { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// Unit Kind
        /// </summary>
        public PackagingUnitKind UnitKind { get; set; }

        /// <summary>
        /// Cost
        /// </summary>
        [DataType(DataType.Currency)]
        public IMoney Cost { get; set; }

        /// <summary>
        /// Transaction Date
        /// </summary>
        public DateTime TransactionDate { get; set; }

        /// <summary>
        /// Transaction User
        /// </summary>
        public IPerson TransactionUser { get; set; }

    }
}
