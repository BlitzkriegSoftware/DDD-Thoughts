using System.Text.RegularExpressions;
using System;

namespace StuartWilliams.CandyCo.SharedKernels.Models
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
    public interface IUniversalProductCode
    {
        #region "Const, Vars, Props"

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
        public int ProductType { get; set; }

        /// <summary>
        /// Company Code
        /// </summary>
        public int CompanyCode { get; set; }

        /// <summary>
        /// Inventory Id for the company code up to 5 digits
        /// </summary>
        public int InventoryId { get; set; }

        /// <summary>
        /// Checksum
        /// <para><![CDATA[https://en.wikipedia.org/wiki/Check_digit#UPC]]></para>
        /// </summary>
        public int CheckSum { get; set; }

        /// <summary>
        /// CheckSum Update on this Instance
        /// </summary>
        public void CheckSumUpdate();

        /// <summary>
        /// Is this a valid UPC
        /// </summary>
        /// <returns>True if so</returns>
        public bool IsValid();

        #endregion

    }
}