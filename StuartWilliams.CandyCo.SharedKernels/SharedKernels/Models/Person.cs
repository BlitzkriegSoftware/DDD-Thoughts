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
    /// Person
    /// </summary>
    public class Person : IPerson
    {
        /// <summary>
        /// PK
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Kind: Person
        /// </summary>
        public PersonKind Kind { get; set; }

        /// <summary>
        /// Name: Last
        /// </summary>
        public string NameLast { get; set; }

        /// <summary>
        /// Name: First
        /// </summary>
        public string NameFirst { get; set; }

        /// <summary>
        /// Name is first+(space)+last
        /// </summary>
        public string Name { 
            get {  
                return $"{NameFirst} {NameLast}"; 
            } 
            set {
                if(string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value));
                var index = value.IndexOf(' ');
                if (index == -1) throw new ArgumentException(nameof(value));
                this.NameFirst= value.Substring(0, index);
                this.NameLast= value.Substring(index + 1);
            } 
        } 

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Phone: Mobile
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Phone: Other
        /// </summary>
        public string OtherPhone { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        public Location Address { get; set; }

        /// <summary>
        /// Is Deleted
        /// </summary>
        public bool IsDeleted { get; set; }

    }
}
