using System.Collections.Generic;
using SBS.BLL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL.Interfaces
{
    public interface IPedalBll :  IGetEntityBLLBase<Pedal>, IUpdateDeleteEntityBLLBase<Pedal>
    {
        /// <summary>
        /// Add a new Pedal
        /// </summary>
        /// <param name="name">The Name of the Pedal</param>
        /// <param name="shortName">The Short Name of the Pedal</param>
        /// <param name="manufacturer">The Manufacturer of the Pedal</param>
        /// <param name="hasBatteryConnection">Whether the Pedal has a battery connection</param>
        /// <param name="width">The width of the Pedal, im millimeteres</param>
        /// <param name="height">The height of the Pedal, in millimetres</param>
        /// <param name="depth">The depth of the Pedal, in millimetres</param>
        /// <param name="powerConnection">The Power Connection for the Pedal</param>
        /// <param name="currentDraw">The current draw of the Pedal, in miliamps</param>
        /// <param name="types">A collection of the Types of the Pedal</param>
        /// <param name="jacks">A collection of the Jacks the Pedal has</param>
        /// <param name="images">A collection of Images of the Pedal</param>
        /// <param name="alternativeName">An optional Alternative Name for the Pedal</param>
        /// <param name="weight">An optional value for the Weight of the Pedal</param>
        /// <exception cref="ArgumentNullException">A required parameter was not supplied</exception>
        /// <exception cref="ArgumentException">A parameter was invalid</exception>
        void Add(string name,
                 string shortName,
                 Manufacturer manufacturer,
                 bool hasBatteryConnection,
                 int width,
                 int height,
                 int depth,
                 PowerConnection powerConnection,
                 int currentDraw,
                 IList<PedalType> types,
                 IList<PedalJack> jacks,
                 IList<PedalImage> images,
                 string alternativeName = null,
                 int? weight = null);

        /// <summary>
        /// Verify a Pedal, marking it is available for use
        /// </summary>
        /// <param name="pedal">The Pedal to Verify</param>
        void Verify(Pedal pedal);
    }
}
