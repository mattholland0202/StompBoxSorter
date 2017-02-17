using System;

namespace SBS.Data.Entities
{
    public class Manufacturer : VersionedEntity
    {
        public Manufacturer(string name,
                            string shortName)
        {
            Name        = name;
            ShortName   = shortName;
            DateCreated = DateTime.UtcNow;
            IsVerified  = false;
        }

        public virtual int ManufacturerID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual bool IsVerified { get; set; }
    }
}
