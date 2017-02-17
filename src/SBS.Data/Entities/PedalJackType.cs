namespace SBS.Data.Entities
{
    public class PedalJackType : VersionedEntity
    {
        public virtual int PedalJackTypeID { get; set; }
        public virtual string Name { get; set; }
    }
}
