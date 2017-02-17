using System.Collections.Generic;

namespace SBS.Data.Entities
{
    public class PowerSupply : VersionedEntity
    {
        public virtual int PowerSupplyID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int Depth { get; set; }

        private readonly IList<PowerConnection> powerConnections = new List<PowerConnection>();
        public virtual IList<PowerConnection> PowerConnections
        {
            get
            {
                return powerConnections;
            }
        }
    }
}
