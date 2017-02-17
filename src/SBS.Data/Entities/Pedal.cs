using System;
using System.Collections.Generic;

namespace SBS.Data.Entities
{
    public class Pedal : VersionedEntity
    {
        public Pedal(string name,
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
            Name                 = name;
            AlternativeName      = alternativeName;
            ShortName            = shortName;
            Manufacturer         = manufacturer;
            HasBatteryConnection = hasBatteryConnection;
            Width                = width;
            Height               = height;
            Depth                = depth;
            PowerConnection      = powerConnection;
            CurrentDraw          = currentDraw;
            Weight               = weight;
            DateCreated          = DateTime.UtcNow;
            IsVerified           = false;

            this.types = types;
            this.jacks = jacks;
            this.images = images;
        }

        public virtual int PedalID { get; set; }
        public virtual string Name { get; set; }
        public virtual string AlternativeName { get; set; }
        public virtual string ShortName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual bool HasBatteryConnection { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int Depth { get; set; }
        public virtual int? Weight { get; set; }
        public virtual PowerConnection PowerConnection { get; set; }
        public virtual int CurrentDraw { get; set; }
        public virtual DateTime DateCreated { get; set; }
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
