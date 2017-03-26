using System.Collections.Generic;

namespace SBS.Data.Entities
{
    public class PowerSupply
    {
        public virtual int PowerSupplyID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int Depth { get; set; }

        private readonly IList<PedalPowerConnection> powerConnections = new List<PedalPowerConnection>();
        public virtual IList<PedalPowerConnection> PowerConnections
        {
            get
            {
                return powerConnections;
            }
        }
    }
}
