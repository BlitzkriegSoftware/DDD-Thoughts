
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartWilliams.CandyCo.SharedKernels.Models
{
    /// <summary>
    /// Error Code
    /// </summary>
    public class CandyCoError
    {
        /// <summary>
        /// Error Code
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Exception
        /// </summary>
        public Exception Exception { get; set; }

    }
}
