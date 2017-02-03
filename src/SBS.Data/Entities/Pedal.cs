using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBS.Data.Entities
{
    public class Pedal : VersionedEntity
    {
        public virtual int PedalID { get; set; }
        public virtual string Name { get; set; }
        public virtual string AlternativeName { get; set; }
        public virtual string ShortName { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        private readonly IList<PedalType> types = new List<PedalType>();
        public virtual IList<PedalType> Types
        {
            get
            {
                return types;
            }
        }
    }
}
