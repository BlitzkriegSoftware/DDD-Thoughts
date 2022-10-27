namespace DDD_Ex1.SharedKernels.Book
{
        /// <summary>
        /// Enum: Book Identifier Type
        /// </summary>
        public enum BookIdType
        {
            /// <summary>
            /// Unknown
            /// </summary>
            Unknown = 0,
            /// <summary>
            /// International Standard Book Number
            /// </summary>
            ISBN = 1,
            /// <summary>
            /// International Standard Serial Number
            /// </summary>
            ISSN = 2,
            /// <summary>
            /// PubMed Indexing Number
            /// </summary>
            PMID = 4,
            /// <summary>
            /// Serial Item and Contribution Identifier
            /// </summary>
            SICI = 8,
            /// <summary>
            /// American Society for Testing and Materials (ASTM) standard E250 (Cronic Disease Research Institute)
            /// </summary>
            CODEN = 16,
            /// <summary>
            /// Digital Object Identifier
            /// </summary>
            DOI = 32,
        }
}