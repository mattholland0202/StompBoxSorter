using System.Collections.Generic;

namespace SBS.Data.Entities
{
    public class PedalTypeFamily : VersionedEntity
    {
        public virtual int PedalTypeFamilyID { get; set; }
        public virtual string Name { get; set; }

        private readonly IList<PedalType> pedalTypes = new List<PedalType>();
        public virtual IList<PedalType> PedalTypes
        {
            get
            {
                return pedalTypes;
            }
        }
    }
}
