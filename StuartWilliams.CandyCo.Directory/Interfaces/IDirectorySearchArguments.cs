using StuartWilliams.CandyCo.SharedKernels.Interfaces;

namespace StuartWilliams.CandyCo.Directory.Interfaces
{
    /// <summary>
    /// Interface: Directory Search
    /// </summary>
    public interface IDirectorySearchArguments : ISearchArgumentsBase
    {
        /// <summary>
        /// Kind: Search Scope
        /// </summary>
        public Enums.DirectorySearchScopeKind DirectorySearchScope { get; set; }
    }
}