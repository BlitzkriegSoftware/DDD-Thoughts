namespace StuartWilliams.CandyCo.SharedKernels.Enums
{
    /// <summary>
    /// Location Kind
    /// </summary>
    public enum LocationKind
    {
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// Commercial
        /// </summary>
        Commercial = 1,
        /// <summary>
        /// Residential
        /// </summary>
        Residential = 2,
        /// <summary>
        /// Any place w/o active buidings e.g., empty-land, abandoned-property, etc.
        /// </summary>
        Land = 3,
    }
}
