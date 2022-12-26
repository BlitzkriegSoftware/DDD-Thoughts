using System;

using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;
using StuartWilliams.CandyCo.SharedKernels.Models;

namespace StuartWilliams.CandyCo.Procurement.Models
{
    /// <summary>
    /// Product: Search Arguments
    /// </summary>
    public class ProductSearchArguments : ISearchArgumentsBase
    {
        /// <summary>
        /// UPC
        /// </summary>
        public UniversalProductCode UPC { get; set; }

        /// <summary>
        /// Maximum Price For This Product Per <c>Container</c>
        /// </summary>
        public Money MaximumPrice { get; set; }

        /// <summary>
        /// Container
        /// </summary>
        public ContainerKind Container { get; set; }

        /// <summary>
        /// Quantity Needed
        /// </summary>
        public int QuantityNeeded { get; set; }

        /// <summary>
        /// Needed By TimeStamp
        /// </summary>
        public DateTime NeededByTimeStamp { get; set; }

        #region "ISearchArgumentsBase"

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

        #endregion
    }
}
