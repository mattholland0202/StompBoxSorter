using System;

namespace SBS.Data.Entities
{
    public class Board
    {
        public Board(string name,
                     string shortName,
                     Manufacturer manufacturer,
                     int width,
                     int height,
                     int? weight = null)
        {
            Name         = name;
            ShortName    = shortName;
            Manufacturer = manufacturer;
            Width        = width;
            Height       = height;
            Weight       = weight;
            DateCreated  = DateTime.UtcNow;
            IsVerified   = false;
        }

        public virtual int BoardID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int? Weight { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual bool IsVerified { get; set; }
    }
}
