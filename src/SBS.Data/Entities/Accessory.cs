using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBS.Data.Entities
{
    public class Accessory
    {
        public Accessory(string name,
                         int width,
                         int height,
                         int depth,
                         int? weight = null)
        {
            Name        = name;
            Width       = width;
            Height      = height;
            Depth       = depth;
            Weight      = weight;
            DateCreated = DateTime.UtcNow;
            IsVerified  = false;
        }

        public virtual int AccessoryID { get; set; }
        public virtual string Name { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int Depth { get; set; }
        public virtual int? Weight { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual bool IsVerified { get; set; }
    }
}
