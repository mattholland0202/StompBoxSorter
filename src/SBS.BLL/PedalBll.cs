﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <param name="powerConnection">The Power Connection for the Pedal</param>
        /// <param name="currentDraw">The current draw of the Pedal, in miliamps</param>
        /// <param name="types">A collection of the Types of the Pedal</param>
        /// <param name="jacks">A collection of the Jacks the Pedal has</param>
        /// <param name="images">A collection of Images of the Pedal</param>
        /// <param name="alternativeName">An optional Alternative Name for the Pedal</param>
        /// <param name="weight">An optional value for the Weight of the Pedal</param>
        /// <exception cref="ArgumentNullException">A required parameter was not supplied</exception>
        /// <exception cref="ArgumentException">A parameter was invalid</exception>
        public void Add(string name,
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
                        int? weight = null)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (String.IsNullOrWhiteSpace(shortName))
            {
                throw new ArgumentNullException(nameof(shortName));
            }

            if (manufacturer == null)
            {
                throw new ArgumentNullException(nameof(manufacturer));
            }

            if (powerConnection == null)
            {
                throw new ArgumentNullException(nameof(powerConnection));
            }

            if (types == null)
            {
                throw new ArgumentNullException(nameof(types));
            }
            else if (types.Count() == 0)
            {
                throw new ArgumentException("At least one Pedal Type must be supplied", nameof(types));
            }

            if (jacks == null)
            {
                throw new ArgumentNullException(nameof(jacks));
            }
            else if (jacks.Count() == 0)
            {
                throw new ArgumentException("At least one Pedal Jack must be specified", nameof(jacks));
            }

            if (images == null)
            {
                throw new ArgumentNullException(nameof(images));
            }
            else if (images.Count() == 0)
            {
                throw new ArgumentException("At least one Image must be specified", nameof(images));
            }

            Pedal pedal = new Pedal(name,
                                    shortName,
                                    manufacturer,
                                    hasBatteryConnection,
                                    width,
                                    height,
                                    depth,
                                    powerConnection,
                                    currentDraw,
                                    types,
                                    jacks,
                                    images,
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