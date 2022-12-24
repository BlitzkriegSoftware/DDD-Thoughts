using StuartWilliams.CandyCo.SharedKernels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartWilliams.CandyCo.SharedKernels.Models
{
    /// <summary>
    /// Inventory Change Item
    /// </summary>
    public class InventoryChangeItem
    {
        /// <summary>
        /// Transfer Reason aka <c>InventoryChangeOperationKind</c>
        /// </summary>
        public InventoryChangeOperationKind ChangeOperationKind { get; set; }

        /// <summary>
        /// UPC
        /// </summary>
        public UniversalProductCode UPC { get; set; }

        /// <summary>
        /// Quantity
        /// </summary>
        public long Quantity { get; set; }
    }
}
