namespace SBS.Data.Entities
{
    public class Manufacturer : VersionedEntity
    {
        public virtual int ManufacturerID { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }
    }
}
