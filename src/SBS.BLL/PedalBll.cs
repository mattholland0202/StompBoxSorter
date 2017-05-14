using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using SBS.BLL.Base;
using SBS.BLL.Interfaces;
using SBS.BLL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL
{
    public class PedalBll : AbstractBLLBase, IPedalBll
    {
        public PedalBll(IBLL bll) : base(bll)
        {
        }

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
        /// <param name="trueBypass">Is the Pedal True Bypass</param>
        /// <param name="powerConnection">The Power Connection for the Pedal</param>
        /// <param name="currentDraw">The current draw of the Pedal, in miliamps</param>
        /// <param name="types">A collection of the Types of the Pedal</param>
        /// <param name="jacks">A collection of the Jacks the Pedal has</param>
        /// <param name="images">A collection of Images of the Pedal</param>
        /// <param name="creator">The User who created this Pedal</param>
        /// <param name="alternativeName">An optional Alternative Name for the Pedal</param>
        /// <param name="weight">An optional value for the Weight of the Pedal</param>
        /// <exception cref="ArgumentNullException">A required parameter was not supplied</exception>
        /// <exception cref="ArgumentException">A parameter was invalid</exception>
        
        public void Add(string name,
                        string shortName,
                        Manufacturer manufacturer,
                        int width,
                        int height,
                        int depth,
                        bool trueBypass,
                        PedalPowerConnection powerConnection,
                        IList<PedalType> types,
                        IList<PedalJack> jacks,
                        IList<PedalImage> images,
                        User creator,
                        string alternativeName = null,
                        int? weight = null)
        {
            base.CheckParameterForNull(name, nameof(name));
            base.CheckParameterForNull(shortName, nameof(shortName));
            base.CheckParameterForNull(manufacturer, nameof(manufacturer));
            base.CheckParameterForNull(powerConnection, nameof(powerConnection));
            base.CheckParameterForNull(types, nameof(types));
            base.CheckParameterForNull(jacks, nameof(jacks));
            base.CheckParameterForNull(images, nameof(images));
            base.CheckParameterForNull(creator, nameof(creator));

            Pedal pedal = new Pedal(name,
                                    shortName,
                                    manufacturer,
                                    width,
                                    height,
                                    depth,
                                    trueBypass,
                                    powerConnection,
                                    types,
                                    jacks,
                                    images,
                                    creator,
                                    alternativeName,
                                    weight);

            UnitOfWork.PedalRepository.Add(pedal);
        }

        /// <summary>
        /// Delete a Pedal
        /// </summary>
        /// <param name="pedal">The Pedal to Delete</param>
        public void Delete(Pedal pedal)
        {
            if (pedal == null)
            {
                throw new ArgumentNullException(nameof(pedal));
            }

            UnitOfWork.PedalRepository.Delete(pedal);
        }

        /// <summary>
        /// Get a Pedal matching the specified ID
        /// </summary>
        /// <param name="id">The ID of the Pedal to retrieve</param>
        /// <returns>The Pedal matching the supplied ID</returns>
        public Pedal Get(int id)
        {
            var pedal = UnitOfWork.PedalRepository.Get(id);
            return pedal;
        }

        /// <summary>
        /// Get a collection of all Pedals
        /// </summary>
        /// <returns>A collection of all Pedals</returns>
        public IEnumerable<Pedal> GetAll()
        {
            var pedals = UnitOfWork.PedalRepository.GetAll();
            return pedals;
        }

        /// <summary>
        /// Get all Pedals which have been marked as Verified
        /// </summary>
        /// <returns>All Pedals which have been marked as Verified</returns>
        public IEnumerable<Pedal> GetAllVerified()
        {
            var pedals = UnitOfWork.PedalRepository.GetAll().Where(p => p.IsVerified);
            return pedals;
        }

        /// <summary>
        /// Update a Pedal, replacing all existing values with the one supplied
        /// </summary>
        /// <param name="pedal">The Updated Pedal</param>
        public void Update(Pedal pedal)
        {
            UnitOfWork.SaveChanges();
        }

        /// <summary>
        /// Verify a Pedal, marking it is available for use
        /// </summary>
        /// <param name="pedal">The Pedal to Verify</param>
        public void Verify(Pedal pedal)
        {
            pedal.IsVerified = true;
        }
    }
}
