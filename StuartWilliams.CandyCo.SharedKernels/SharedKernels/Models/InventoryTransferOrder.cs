using StuartWilliams.CandyCo.SharedKernels.Interfaces;
using System;
using System.Collections.Generic;

namespace StuartWilliams.CandyCo.SharedKernels.Models
{
    /// <summary>
    /// Inventory Transfer Order
    /// </summary>
    public class InventoryTransferOrder : IEntity, ICloneable
    {
        /// <summary>
        /// From Company
        /// </summary>
        public long FromCompany { get; set; }

        /// <summary>
        /// To Company
        /// </summary>
        public long ToCompany { get; set; }

        /// <summary>
        /// Related Transaction Id
        /// </summary>
        public long RelatedTransactionId { get; set; }

        /// <summary>
        /// Transfer Date
        /// </summary>
        public DateTime TransferDate { get; set; } = DateTime.UtcNow;

        private List<InventoryChangeItem> _items;
        
        /// <summary>
        /// Inventory Items
        /// </summary>
        public List<InventoryChangeItem> Items
        {
            get
            {
                if (_items == null) _items = new List<InventoryChangeItem>();
                return _items;
            }
            set
            {
                _items= value;
            }
        }

        /// <summary>
        /// PK
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// ParentId
        /// </summary>
        public long ParentId { get; set; }

        /// <summary>
        /// Name (optional) as a note
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Is Deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// IsValid
        /// </summary>
        /// <returns>True if so</returns>
        public bool IsValid()
        {
            return 
                (this.Id != 0) &&
                (this.IsDeleted == false) &&
                (this.FromCompany != 0) &&
                (this.ToCompany != 0)
                ;
        }

        /// <summary>
        /// Clone (minus Id and Related Transaction Id)
        /// </summary>
        /// <returns>Clone</returns>
        public object Clone()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            var entity = Newtonsoft.Json.JsonConvert.DeserializeObject<InventoryTransferOrder>(json);
            entity.Id = 0;
            entity.RelatedTransactionId = 0;
            return entity;
        }

    }
}
