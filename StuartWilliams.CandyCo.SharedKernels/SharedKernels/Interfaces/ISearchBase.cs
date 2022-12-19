using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Search Base
    /// </summary>
    public interface ISearchBase
    {

        /// <summary>
        /// Search Phrase
        /// </summary>
        public string SearchPhrase { get; set; }

        /// <summary>
        /// Allow: Wild Cards
        /// </summary>
        public bool AllowWildCards { get; set; }

        /// <summary>
        /// Allow: Logic Operators
        /// </summary>
        public bool AllowLogicOperators { get; set; }

        /// <summary>
        /// Allow: Starts With
        /// </summary>
        public bool AllowStartsWith { get; set; }

        /// <summary>
        /// Allow: Fuzzy Match
        /// </summary>
        public bool AllowFuzzyMatch { get; set; }

    }
}
