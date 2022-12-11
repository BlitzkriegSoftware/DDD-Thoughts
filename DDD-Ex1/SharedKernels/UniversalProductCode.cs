using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StuartWilliams.CandyCo.SharedKernels
{

    /// <summary>
    /// UniversalProductCode (UPC-A) 12 Digits
    /// <para>Identifier for a Product</para>
    /// <list type="bullet">
    /// <listheader>Sections (total of 4, space separated)</listheader>
    /// <item>Product Type (1) 0</item>
    /// <item>Company Code (5) 1..{5}</item>
    /// <item>Inventory Id (5) 6..{5}</item>
    /// <item>Check Digit  (1) 11..</item>
    /// </list>
    /// <para><![CDATA[https://www.gtin.info/barcode-101/]]></para>
    /// </summary>
    public class UniversalProductCode
    {
        #region "CTOR"

        /// <summary>
        /// CTOR
        /// </summary>
        public UniversalProductCode() { }

        /// <summary>
        /// CTOR
        /// </summary>
        public UniversalProductCode(string upc)
        {
            (this.ProductType, this.CompanyCode, this.InventoryId, this.CheckSum) = UpcParse(upc);
            CheckSumUpdate();
        }

        #endregion

        #region "Const, Vars, Props"

        /// <summary>
        /// RegEx: Digits Only
        /// </summary>
        public readonly Regex DigitsOnly = new("^[0-9]+$");

        /// <summary>
        /// The company Id of Candy Co.
        /// </summary>
        public const int CandyCoId = 12345;

        /// <summary>
        /// Style of Encoding
        /// </summary>
        public const string UpcKind = "UPC-A";

        /// <summary>
        /// 0: General Merchandise
        /// </summary>
        public const int ProductTypeDefault = 0;

        /// <summary>
        /// Leftmost single digit indicating product type
        /// </summary>
        public int ProductType { get; set; } = ProductTypeDefault;

        /// <summary>
        /// Company Code
        /// </summary>
        public int CompanyCode { get; set; } = CandyCoId;

        /// <summary>
        /// Inventory Id for the company code up to 5 digits
        /// </summary>
        public int InventoryId { get; set; } = 0;

        /// <summary>
        /// Checksum
        /// <para><![CDATA[https://en.wikipedia.org/wiki/Check_digit#UPC]]></para>
        /// </summary>
        public int CheckSum { get; set; }

        /// <summary>
        /// CheckSum Update on this Instance
        /// </summary>
        public void CheckSumUpdate()
        {
            this.CheckSum = CheckSumCompute(this.ToStringNoSpacesNoCheckSum());
        }

        /// <summary>
        /// Is this a valid UPC
        /// </summary>
        /// <returns>True if so</returns>
        public bool IsValid()
        {
            bool isOk = true;

            if (this.ProductType < 0) isOk = false;
            if (this.ProductType > 9) isOk = false;

            if (this.CompanyCode <= 0) isOk = false;
            if (this.CompanyCode > 99999) isOk = false;

            if (this.InventoryId <= 0) isOk = false;
            if (this.InventoryId > 99999) isOk = false;

            if (this.CheckSum < 0) isOk = false;
            if (this.CheckSum > 9) isOk = false;
            if(this.CheckSum != CheckSumCompute(this.ToStringNoSpacesNoCheckSum())) isOk = false;

            var upc = this.ToStringNoSpace();
            if (string.IsNullOrWhiteSpace(upc)) isOk = false;
            if (upc.Length != 12) isOk = false;
            if (!DigitsOnly.IsMatch(upc)) isOk = false;
            return isOk;
        }

        #endregion

        #region "Static Helpers"

        /// <summary>
        /// Parse a UPC string
        /// </summary>
        /// <param name="upc">UPC</param>
        /// <returns>Tuple: ProductType, CompanyCode, InventoryId</returns>
        public static (int, int, int, int) UpcParse(string upc)
        {
            upc ??= string.Empty;
            upc = upc.Replace(" ", "");
            upc = upc.PadLeft(12, '0');
            var productType = Convert.ToInt32(upc[..1]);
            var companyCode = Convert.ToInt32(upc.Substring(1, 5));
            var inventoryId = Convert.ToInt32(upc.Substring(6, 5));
            var checkSum = Convert.ToInt32(upc.Substring(11, 1));
            return (productType, companyCode, inventoryId, checkSum);
        }

        /// <summary>
        /// The final digit of a Universal Product Code is a check digit computed as follows:[3]
        /// </summary>
        /// <para>
        /// Add the digits in the odd-numbered positions from the right (first, third, fifth, etc.) 
        ///    not including the check digit) together and multiply by three.
        /// </para>
        /// <para>
        /// Add the digits (up to but not including the check digit)
        /// in the even-numbered positions (second, fourth, sixth, etc.) to the result.
        /// </para>
        /// <para>
        /// Take the remainder of the result divided by 10 (ie. the modulo 10 operation).
        ///      If the remainder is equal to 0 then use 0 as the check digit, and
        /// </para>
        /// <para>
        /// if not 0 subtract the remainder from 10 to derive the check digit.
        ///</para>
        ///<example>
        /// For instance, the UPC-A barcode for a box of tissues is "036000241457".
        ///  The last digit is the check digit "7", and if the other numbers are correct
        ///    then the check digit calculation must produce 7.
        ///  Add the odd number digits: 0+6+0+2+1+5 = 14.
        ///    Multiply the result by 3: 14 × 3 = 42.
        /// Add the even number digits: 3+0+0+4+4 = 11.
        /// Add the two results together: 42 + 11 = 53.
        /// To calculate the check digit, take the remainder of (53 / 10), which is also known as (53 modulo 10), and if not 0, subtract from 10. Therefore, the check digit value is 7. i.e. (53 / 10) = 5 remainder 3; 10 - 3 = 7.
        /// </example>
        /// <example>
        /// To calculate the check digit for the following food item "01010101010x".
        /// Add the odd number digits: 0+0+0+0+0+0 = 0.
        ///      Multiply the result by 3: 0 x 3 = 0.
        /// Add the even number digits: 1+1+1+1+1=5.
        /// Add the two results together: 0 + 5 = 5.
        /// To calculate the check digit, take the remainder of (5 / 10), which is also known as (5 modulo 10), and if not 0, subtract from 10: i.e. (5 / 10) = 0 remainder 5; (10 - 5) = 5. Therefore, the check digit x value is 5.
        /// </example>
        /// <remarks>
        /// <![CDATA[https://www.gs1.org/services/check-digit-calculator#]]>
        /// </remarks>
        /// <param name="upcText">Value to compute for</param>
        /// <returns>Checksum</returns>
        public static int CheckSumCompute(string upcText)
        {
            string upcNoCC = upcText;

            int odd = 0;
            for (int i = 0; i < upcNoCC.Length; i += 2)
            {
                var digit = upcNoCC.Substring(i, 1);
                odd += Convert.ToInt32(digit);
            }

            int even = 0;
            for (int i = 1; i < upcNoCC.Length; i += 2)
            {
                var digit = upcNoCC.Substring(i, 1);
                even += Convert.ToInt32(digit);
            }

            int checkSum = odd * 3 + even;
            checkSum %= 10;
            if (checkSum != 0)
            {
                checkSum = 10 - checkSum;
            }

            return checkSum;
        }

        #endregion

        #region "Overrides"

        /// <summary>
        /// Compare two UPCs
        /// </summary>
        /// <param name="obj">thing to compare to</param>
        /// <returns>true if equals</returns>
        public override bool Equals(object? obj)
        {
            bool result;
            if (obj is not UniversalProductCode that)
            {
                result = false;
            }
            else
            {
                result = (this.ProductType == that?.ProductType) &&
                         (this.CompanyCode == that?.CompanyCode) &&
                         (this.InventoryId == that?.InventoryId) &&
                         (this.CheckSum == that?.CheckSum);

            }
            return result;
        }

        /// <summary>
        /// Get HashCode
        /// </summary>
        /// <returns>HashCode</returns>
        public override int GetHashCode()
        {
            return this.ProductType.GetHashCode() ^
                   this.CompanyCode.GetHashCode() ^
                   this.InventoryId.GetHashCode();
        }

        /// <summary>
        /// Put the UPC in the correct format P_COMPA_INVEN_C
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var pt = this.ProductType.ToString().PadLeft(1, '0');
            var cc = this.CompanyCode.ToString().PadLeft(5, '0');
            var ii = this.InventoryId.ToString().PadLeft(5, '0');
            var cs = this.CheckSum.ToString().PadLeft(1, '0');

            return $"{pt} {cc} {ii} {cs}";
        }

        /// <summary>
        /// Put the UPC in the correct format with NO Spaces
        /// </summary>
        /// <returns></returns>
        public string ToStringNoSpace()
        {
            return this.ToString().Replace(" ", "");
        }

        /// <summary>
        /// To String w/o spaces or checksum
        /// </summary>
        /// <returns>(sic)</returns>
        public string ToStringNoSpacesNoCheckSum()
        {
            var upc = this.ToStringNoSpace();
            return upc[..^1];
        }
        #endregion

    }
}