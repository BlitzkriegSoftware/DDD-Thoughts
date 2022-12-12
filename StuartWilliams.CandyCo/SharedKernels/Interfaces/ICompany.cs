using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Models;
using System.Collections.Generic;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Company
    /// </summary>
    public interface ICompany
    {
        /// <summary>
        /// PK
        /// </summary>
        long Id { get; set; }

        /// <summary>
        /// Address
        /// </summary>
        Location Address { get; set; }

        /// <summary>
        /// Kind: Company
        /// </summary>
        CompanyKind Kind { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// People
        /// </summary>
        List<IPerson> People { get; set; }
    }
}