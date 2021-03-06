﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("SBS.BLL.Tests")]
namespace SBS.Data.Entities
{
    public class Pedal
    {
        public Pedal(string name,
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
            Name                = name;
            AlternativeName     = alternativeName;
            ShortName           = shortName;
            Manufacturer        = manufacturer;
            Width               = width;
            Height              = height;
            Depth               = depth;
            TrueBypass          = trueBypass;
            PowerConnection     = powerConnection;
            Weight              = weight;
            DateCreated         = DateTime.UtcNow;
            Creator             = creator;
            IsVerified          = false;

            this.types = types;
            this.jacks = jacks;
            this.images = images;
        }

        /// <summary>
        /// Required for Unit Testing
        /// </summary>
        internal Pedal() { }

        public virtual int PedalID { get; set; }
        public virtual string Name { get; set; }
        public virtual string AlternativeName { get; set; }
        public virtual string ShortName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int Depth { get; set; }
        public virtual bool TrueBypass { get; set; }
        public virtual int? Weight { get; set; }
        public virtual PedalPowerConnection PowerConnection { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual User Creator { get; set; }
        public virtual bool IsVerified { get; set; }

        private readonly IList<PedalJack> jacks = new List<PedalJack>();
        public virtual IList<PedalJack> Jacks
        {
            get
            {
                return jacks;
            }
        }

        private readonly IList<PedalType> types = new List<PedalType>();
        public virtual IList<PedalType> Types
        {
            get
            {
                return types;
            }
        }

        private readonly IList<PedalImage> images = new List<PedalImage>();
        public virtual IList<PedalImage> Images
        {
            get
            {
                return images;
            }
        }
    }
}
