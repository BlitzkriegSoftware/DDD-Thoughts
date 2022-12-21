using System;
using System.Collections.Generic;

using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Models;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Company
    /// </summary>
    public interface ICompany : IEntity, ICloneable
    {
        /// <summary>
        /// Address
        /// </summary>
        Location Address { get; set; }

        /// <summary>
        /// Kind: Company
        /// </summary>
        CompanyKind Kind { get; set; }

        /// <summary>
        /// People
        /// </summary>
        List<Person> People { get; set; }

    }
}