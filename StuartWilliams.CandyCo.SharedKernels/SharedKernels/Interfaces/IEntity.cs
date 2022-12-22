namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Entity
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// PK
        /// </summary>
        long Id { get; set; }

        /// <summary>
        /// Parent Id
        /// </summary>
        long ParentId { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Is Deleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Is Valid Entity
        /// </summary>
        /// <returns></returns>
        public bool IsValid();

    }
}
