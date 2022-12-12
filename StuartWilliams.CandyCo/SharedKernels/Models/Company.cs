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
    public class Company : ICompany
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

    }
}
