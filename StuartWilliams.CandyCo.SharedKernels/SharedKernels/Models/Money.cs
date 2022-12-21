using StuartWilliams.CandyCo.SharedKernels.Interfaces;
using System.Globalization;

namespace StuartWilliams.CandyCo.SharedKernels.Models
{
    /// <summary>
    /// Money
    /// </summary>
    public class Money : IMoney
    {

        /// <summary>
        /// CTOR
        /// </summary>
        public Money() : this(0m, new CurrencyInfo("USD")) { }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="amount">(sic)</param>
        /// <param name="currencyCodeText">(sic)</param>
        public Money(decimal amount, string currencyCodeText) : this(amount, new CurrencyInfo(currencyCodeText)) { }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="amount">decimal</param>
        /// <param name="currencyInfo">CurrencyInfo</param>
        public Money(decimal amount, CurrencyInfo currencyInfo)
        {
            Amount = amount;
            CurrencyInfo = currencyInfo;
        }

        /// <summary>
        /// Amount
        /// </summary>
        public decimal Amount { get; set; } = decimal.Zero;

        /// <summary>
        /// CurrencyInfo
        /// </summary>
        public CurrencyInfo CurrencyInfo { get; set; } = new CurrencyInfo("USD");

        /// <summary>
        /// Is Valid
        /// </summary>
        /// <returns>True if so</returns>
        public bool IsValid()
        {
            return
                (this.CurrencyInfo != null) &&
                !string.IsNullOrWhiteSpace(this.CurrencyInfo.IsoCurrencyCodeText)
                ;
        }

        /// <summary>
        /// Get HashCode
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            return
                this.Amount.GetHashCode() ^
                this.CurrencyInfo.GetHashCode();
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj">that</param>
        /// <returns>True if so</returns>
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            return obj is Money that &&
                this.Amount.Equals(that.Amount) &&
                this.CurrencyInfo.Equals(that.CurrencyInfo);
        }

        /// <summary>
        /// Debug String
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!this.IsValid())
            {
                return Amount.ToString("c");
            }
            else
            {
                return $"{this.Amount.ToString("C", CultureInfo.CreateSpecificCulture(CurrencyInfo.Locale))}";
            }
        }

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns>Exact Clone</returns>
        public object Clone()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            var entity = Newtonsoft.Json.JsonConvert.DeserializeObject<Money>(json);
            return entity;
        }
    }
}
