using System.ComponentModel.DataAnnotations;

using StuartWilliams.CandyCo.SharedKernels.Enums;
using StuartWilliams.CandyCo.SharedKernels.Models;

namespace StuartWilliams.CandyCo.SharedKernels.Models
{
    /// <summary>
    /// Model: Location
    /// </summary>
    public class Location
    {
        /// <summary>
        /// PK
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Location Name
        /// </summary>
        public string LocationName { get; set; }

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
        public bool IsValidMailingAddress()
        {
            return
                !string.IsNullOrEmpty(this.Addreesee) &&
                !string.IsNullOrEmpty(this.AddressLine1) &&
                !string.IsNullOrEmpty(this.AddressLine1) &&
                !string.IsNullOrEmpty(this.City) &&
                !string.IsNullOrEmpty(this.StateOrProvince) &&
                !string.IsNullOrEmpty(this.PostalCode) &&
                (this.Kind != LocationKind.Unknown)
                ;
        }

        /// <summary>
        /// GeoCoded: Is Coded
        /// </summary>
        /// <returns></returns>
        public bool IsGeoCoded()
        {
            if(this.Coordinates== null) return false;

            return
                (this.Coordinates.Confidence > 0) &&
                (this.Coordinates.Latitude != 0) &&
                (this.Coordinates.Longitude != 0)
                ;
        }

        /// <summary>
        /// Is this a valid DB location record
        /// </summary>
        /// <returns></returns>
        public bool IsLocationRecord()
        {
            return
                (
                    (this.Id != 0) &&
                    !string.IsNullOrWhiteSpace(this.LocationName) &&
                    (this.Kind != LocationKind.Unknown)
                ) && (
                    this.IsGeoCoded() ||
                    this.IsValidMailingAddress() 
                )
                ;


        }

    }
}
