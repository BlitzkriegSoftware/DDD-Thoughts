using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;
using StuartWilliams.CandyCo.SharedKernels.Models;
using System.Collections.Generic;

namespace StuartWilliams.CandyCo.Directory.Interfaces
{
    /// <summary>
    /// Interface: Company Management
    /// </summary>
    public interface ICompanyManagement : ICrud
    {
        /// <summary>
        /// Associate a person to a company
        /// </summary>
        /// <param name="CompanyId">(pk)</param>
        /// <param name="PersonId">(pk)</param>
        /// <param name="newKinds">(flags) Person Kinds to Add (0 is none)</param>
        /// <param name="errors">(sic)</param>
        /// <returns>True if so</returns>
        bool CompanyAssociatePerson(long CompanyId, long PersonId, PersonKind newKinds, out IEnumerable<CandyCoError> errors);

        /// <summary>
        /// Disassociate a person from a company
        /// </summary>
        /// <param name="CompanyId">(pk)</param>
        /// <param name="PersonId">(pk)</param>
        /// <param name="errors">(sic)</param>
        /// <returns>True if so</returns>
        bool CompanyDisassociatePerson(long CompanyId, long PersonId, out IEnumerable<CandyCoError> errors);
    }
}
