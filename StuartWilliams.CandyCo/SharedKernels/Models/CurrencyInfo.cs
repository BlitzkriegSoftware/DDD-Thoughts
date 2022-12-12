using System;
using System.ComponentModel.DataAnnotations;

using StuartWilliams.CandyCo.SharedKernels.Lookups;

namespace StuartWilliams.CandyCo.SharedKernels.Models
{

    /// <summary>
    /// Currency Info (ISO 4217)
    /// </summary>
    public class CurrencyInfo
    {

        /// <summary>
        /// CTOR
        /// </summary>
        public CurrencyInfo() { }

        /// <summary>
        /// CTOR
        /// </summary>
        public CurrencyInfo(
            string isoCurrencyCodeText, 
            string isoCurrencyCodeDigits,
            int placesAfterDecimal,
            string description
        ) { 
            this.IsoCurrencyCodeText = isoCurrencyCodeText;
            this.IsoCurrencyCodeDigits = isoCurrencyCodeDigits;
            this.PlacesAfterDecimal= placesAfterDecimal;
            this.Description = description;
        }

        /// <summary>
        /// CTOR
        /// </summary>
        /// <param name="currencyCode">ISO 4217 Currency Code (text)</param>
        public CurrencyInfo(string currencyCode)
        {
            CurrencyInfo model = null;
            if(CurencyCodeList.Iso4217.ContainsKey(currencyCode)) model = CurencyCodeList.Iso4217[currencyCode];
            if(model is not null)
            {
                this.IsoCurrencyCodeText = model.IsoCurrencyCodeText;
                this.IsoCurrencyCodeDigits= model.IsoCurrencyCodeDigits;
                this.Description = model.Description;
                this.PlacesAfterDecimal = model.PlacesAfterDecimal;
            }
        }

        /// <summary>
        /// ISO Currency Code
        /// </summary>
        [StringLength(maximumLength: 3, MinimumLength =1)]
        public string IsoCurrencyCodeText { get; set; }

        /// <summary>
        /// ISO Currency Code
        /// </summary>
        [StringLength(maximumLength: 3, MinimumLength = 1)]
        public string IsoCurrencyCodeDigits { get; set; }

        /// <summary>
        /// Places After Decimal
        /// </summary>
        [Range(minimum: 0, maximum: 5)]
        public int PlacesAfterDecimal { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Is the current text code in ISO 4217 list?
        /// </summary>
        public bool IsoCurrencyCodeTextIsInList
        {
            get
            {
                return Lookups.CurencyCodeList.Iso4217.ContainsKey(this.IsoCurrencyCodeText);
            }
        }

        /// <summary>
        /// Is Valid?
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            return
                !string.IsNullOrWhiteSpace(this.IsoCurrencyCodeText) &&
                !string.IsNullOrWhiteSpace(this.IsoCurrencyCodeDigits) &&
                !string.IsNullOrWhiteSpace(this.Description) &&
                this.IsoCurrencyCodeText.Length > 0 &&
                this.IsoCurrencyCodeDigits.Length > 0 &&
                this.Description.Length > 0 &&
                this.PlacesAfterDecimal >= 0 &&
                this.IsoCurrencyCodeTextIsInList
                ;
        }

        /// <summary>
        /// Equals
        /// </summary>
        /// <param name="obj">thing to compare</param>
        /// <returns>True if so</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (obj is not CurrencyInfo) return false;
            CurrencyInfo that = (CurrencyInfo)obj;
            return
                this.IsoCurrencyCodeText.Equals(that.IsoCurrencyCodeText) &&
                this.IsoCurrencyCodeDigits.Equals(that.IsoCurrencyCodeDigits) &&
                this.Description.Equals(that.Description) &&
                this.PlacesAfterDecimal == that.PlacesAfterDecimal
                ;
        }

        /// <summary>
        /// Get Hash Code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return 
               ((this.IsoCurrencyCodeText is null) ? this.IsoCurrencyCodeText.GetHashCode() : 0) ^
               ((this.IsoCurrencyCodeDigits is null) ? this.IsoCurrencyCodeDigits.GetHashCode() : 0) ^
               ((this.Description is null) ? this.Description.GetHashCode() : 0) ^
               this.PlacesAfterDecimal.GetHashCode()
               ;
        }

        /// <summary>
        /// Debug String
        /// </summary>
        /// <returns>(sic)</returns>
        public override string ToString()
        {
            return $"{this.IsoCurrencyCodeText} ({this.IsoCurrencyCodeDigits}), Places: {this.PlacesAfterDecimal}, {this.Description}";
        }

    }

}
