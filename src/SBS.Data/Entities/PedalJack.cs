namespace SBS.Data.Entities
{
    public class PedalJack : VersionedEntity
    {
        public virtual int PedalJackID { get; set; }
        public virtual Pedal Pedal { get; set; }
        public virtual PedalJackType Type { get; set; }
        public virtual string Name { get; set; }
    }
}
