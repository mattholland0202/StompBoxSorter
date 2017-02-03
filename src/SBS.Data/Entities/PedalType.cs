namespace SBS.Data.Entities
{
    public class PedalType : VersionedEntity
    {
        public virtual int PedalTypeID { get; set; }
        public virtual string Name { get; set; }
        public virtual PedalTypeFamily Family { get; set; }
    }
}
