using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StuartWilliams.CandyCo.Directory.Enums
{
    /// <summary>
    /// Kind: Directory Search Scope
    /// </summary>
    [Flags]
    public enum DirectorySearchScopeKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Person
        /// </summary>
        Person = 1,
        /// <summary>
        /// Company
        /// </summary>
        Company = 2,

        /// <summary>
        /// Both Company and Person
        /// </summary>
        Both = Person | 
               Company
    }
}
