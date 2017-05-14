using System;

namespace SBS.Data.Entities
{
    public class Manufacturer
    {
        public Manufacturer(string name,
                            string shortName,
                            User creator)
        {
            Name        = name;
            ShortName   = shortName;
            DateCreated = DateTime.UtcNow;
            Creator     = creator;
            IsVerified  = false;
        }

        /// <summary>
        /// Required for Unit Testing
        /// </summary>
        internal Manufacturer() { }

        public virtual int ManufacturerID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual User Creator { get; set; }
        public virtual bool IsVerified { get; set; }
    }
}
