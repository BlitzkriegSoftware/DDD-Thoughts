using System;
using System.ComponentModel.DataAnnotations;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Money
    /// </summary>
    public interface IMoney : ICloneable
    {
        /// <summary>
        /// Amount
        /// </summary>
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Currency Code
        /// <para>ISO 4217 (<![CDATA[https://en.wikipedia.org/wiki/ISO_4217]]>)</para>
        /// </summary>
        public Models.CurrencyInfo CurrencyInfo { get; set; }
    }
}
