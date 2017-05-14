using System;
using System.Collections.Generic;

namespace SBS.Data.Entities
{
    public class PowerSupply
    {
        public virtual int PowerSupplyID { get; set; }
        public virtual string Name { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int Depth { get; set; }
        public virtual int? Weight { get; set; }
        public virtual int TotalCurrentSupply { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual User Creator { get; set; }
        public virtual bool IsVerified { get; set; }

        private readonly IList<PowerSupplyOutput> powerConnections = new List<PowerSupplyOutput>();
        public virtual IList<PowerSupplyOutput> PowerConnections
        {
            get
            {
                return powerConnections;
            }
        }
    }
}
