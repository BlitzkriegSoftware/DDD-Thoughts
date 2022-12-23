using System.Collections.Generic;

using StuartWilliams.CandyCo.Freight.Models;
using StuartWilliams.CandyCo.SharedKernels.Interfaces;
using StuartWilliams.CandyCo.SharedKernels.Models;

namespace StuartWilliams.CandyCo.Freight.Interfaces
{
    /// <summary>
    /// Interface: Freight Managment
    /// </summary>
    public interface IFreightManagment : ICrud
    {

        /// <summary>
        /// Find shippers
        /// </summary>
        /// <param name="shippment">IShipment</param>
        /// <param name="errors">(errors)</param>
        /// <returns>List of shippers</returns>
        IEnumerable<ICompany> FindShippers(IShipment shippment, out IEnumerable<CandyCoError> errors);

        /// <summary>
        /// Consign to shipper
        /// </summary>
        /// <param name="shipper">ICompany</param>
        /// <param name="shippment">IShipment</param>
        /// <param name="errors">(errors)</param>
        /// <returns>True on success</returns>
        bool ConsignToShipper(ICompany shipper, IShipment shippment, out IEnumerable<CandyCoError> errors);

        /// <summary>
        /// Event Handler Delegate: Shipper Status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ShipperStatusHandler(object sender, ShipperEventArgs e);

        /// <summary>
        /// Event: Shipper Status
        /// </summary>
        event ShipperStatusHandler ShipperReturnEvent;
    }
}