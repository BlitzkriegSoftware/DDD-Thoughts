using StuartWilliams.CandyCo.SharedKernels.Interfaces;

namespace StuartWilliams.CandyCo.SharedKernels.Models
{
    /// <summary>
    /// Money
    /// </summary>
    public class Money : IMoney
    {

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; set; } = decimal.Zero;

        /// <summary>
        /// CurrencyInfo
        /// </summary>
        public CurrencyInfo CurrencyInfo { get; set; } = new CurrencyInfo("USD");
    }
}
