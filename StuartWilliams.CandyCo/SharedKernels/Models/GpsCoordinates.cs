namespace StuartWilliams.CandyCo.SharedKernels.Models
{
    /// <summary>
    /// Gps Coordinates
    /// </summary>
    public class GpsCoordinates
    {
        /// <summary>
        /// Latitude
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        public decimal Longitude { get; set; }

        /// <summary>
        /// Elevation
        /// </summary>
        public decimal Elevation { get; set; }

        /// <summary>
        /// Confidence as a Percent
        /// </summary>
        public decimal Confidence { get; set; }

        /// <summary>
        /// Is Valid GeoCode
        /// </summary>
        /// <returns>True if so</returns>
        public bool IsValid()
        {
            return
                (this.Confidence > 0) &&
                (this.Longitude != 0) &&
                (this.Latitude != 0)
                ;
        }
    }
}
