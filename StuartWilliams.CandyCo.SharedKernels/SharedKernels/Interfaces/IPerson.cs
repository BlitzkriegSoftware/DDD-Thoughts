using System.ComponentModel.DataAnnotations;

using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Models;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Person
    /// </summary>
    public interface IPerson
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
        /// E-Mail
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        /// <summary>
        /// Phone: Mobile
        /// </summary>
        [DataType(DataType.PhoneNumber)]
        public string MobilePhone { get; set; }

        /// <summary>
        /// Phone: Other
        /// </summary>
        [DataType(DataType.PhoneNumber)]
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
