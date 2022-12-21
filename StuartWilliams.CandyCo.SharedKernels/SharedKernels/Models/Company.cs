using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;

namespace StuartWilliams.CandyCo.SharedKernels.Models
{
    /// <summary>
    /// Company
    /// </summary>
    public class Company : ICompany, IEntity, ICloneable
    {
        /// <summary>
        /// PK
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Kind: Company
        /// </summary>
        public CompanyKind Kind { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public Location Address { get; set; }

        /// <summary>
        /// People
        /// </summary>
        public List<Models.Person> People { get; set; }

        /// <summary>
        /// Is Deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns>Clone with Id of Zero (0)</returns>
        public object Clone()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            var entity = Newtonsoft.Json.JsonConvert.DeserializeObject<Company>(json);
            entity.Id = 0;
            return entity;
        }

        /// <summary>
        /// Is Valid
        /// </summary>
        /// <returns>True if so</returns>
        public bool IsValid()
        {
            return 
                (Id !=0) &&
                !string.IsNullOrWhiteSpace(this.Name) &&
                (this.Kind != CompanyKind.Unknown)
                ;
        }
    }
}
