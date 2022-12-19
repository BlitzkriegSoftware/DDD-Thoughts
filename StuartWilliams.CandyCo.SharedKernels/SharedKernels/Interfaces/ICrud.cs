using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: CRUD
    /// </summary>
    public interface ICrud
    {
        /// <summary>
        /// Delete
        /// </summary>
        /// <typeparam name="T">type</typeparam>
        /// <param name="Id">(pk)</param>
        /// <returns>True if so</returns>
        bool Delete<T>(long Id);

        /// <summary>
        /// Add/Update
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model">Model of T</param>
        /// <returns>Updated Model</returns>
        T AddUpdate<T>(T model);

        /// <summary>
        /// Find by Id
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="Id">pk</param>
        /// <returns>T or null</returns>
        T FindById<T>(long Id);
    }
}
