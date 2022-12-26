using StuartWilliams.CandyCo.SharedKernels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuartWilliams.CandyCo.SharedKernels.Interfaces
{
    /// <summary>
    /// Interface: Shipment
    /// </summary>
    public interface IShipment : IEntity, ICloneable
    {
        /// <summary>
        /// Weight in Killos 
        /// </summary>
        decimal Weight { get; set; }

        /// <summary>
        /// Container
        /// </summary>
        ContainerKind Container { get; set; }

        /// <summary>
        /// Contents
        /// </summary>
        public ContentsKind Contents { get; set; }

        /// <summary>
        /// From Company
        /// </summary>
        long FromCompany { get; set; }

        /// <summary>
        /// To Company
        /// </summary>
        long ToCompany { get; set; }

        /// <summary>
        /// Location: From
        /// </summary>
        ILocation FromLocation { get; set; }

        /// <summary>
        /// Location: To
        /// </summary>
        ILocation ToLocation { get; set; }

    }
}
