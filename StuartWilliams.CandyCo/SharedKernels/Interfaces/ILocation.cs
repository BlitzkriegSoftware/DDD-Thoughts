using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Models;
using System.ComponentModel.DataAnnotations;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Model: Location
    /// </summary>
    public interface ILocation
    {
        /// <summary>
        /// PK
        /// </summary>
        long Id { get; set; }

        /// <summary>
        /// Location Name
        /// </summary>
        string LocationName { get; set; }

        /// <summary>
        /// Location Kind
        /// </summary>
        public LocationKind Kind { get; set; }

        /// <summary>
        /// Who / What is Receiving
        /// </summary>
        public string Addreesee { get; set; }

        /// <summary>
        /// Primary Address Line
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Address Line 2
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Address Line 3
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Address Line 4
        /// </summary>
        public string AddressLine4 { get; set; }

        /// <summary>
        /// City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State Or Province
        /// </summary>
        public string StateOrProvince { get; set; }

        /// <summary>
        /// Postal Code
        /// </summary>
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }

        /// <summary>
        /// GPS Coordinates
        /// </summary>
        public GpsCoordinates Coordinates { get; set; }

        /// <summary>
        /// Mailing Address: Is Valid
        /// </summary>
        /// <returns>True if so</returns>
        public bool IsValidMailingAddress();

        /// <summary>
        /// GeoCoded: Is Coded
        /// </summary>
        /// <returns></returns>
        public bool IsGeoCoded();

        /// <summary>
        /// Is this a valid DB location record
        /// </summary>
        /// <returns></returns>
        public bool IsLocationRecord();

    }
}