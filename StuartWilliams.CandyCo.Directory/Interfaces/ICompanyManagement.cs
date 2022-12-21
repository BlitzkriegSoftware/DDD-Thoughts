using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;

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
        /// <returns>True if so</returns>
        bool CompanyAssociatePerson(long CompanyId, long PersonId, PersonKind newKinds);

        /// <summary>
        /// Disassociate a person to a company
        /// </summary>
        /// <param name="CompanyId">(pk)</param>
        /// <param name="PersonId">(pk)</param>
        /// <returns>True if so</returns>
        bool CompanyDisassociatePerson(long CompanyId, long PersonId);
    }
}
