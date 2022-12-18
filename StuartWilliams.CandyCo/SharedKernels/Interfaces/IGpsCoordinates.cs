namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: GPS Coordinates
    /// </summary>
    public interface IGpsCoordinates
    {
        /// <summary>
        /// Confidence as a Percent
        /// </summary>
        decimal Confidence { get; set; }

        /// <summary>
        /// Elevation
        /// </summary>
        decimal Elevation { get; set; }
        /// <summary>
        /// Latitude
        /// </summary>
        decimal Latitude { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        decimal Longitude { get; set; }

        /// <summary>
        /// Is Valid GeoCode
        /// </summary>
        /// <returns>True if so</returns>
        bool IsValid();
    }
}