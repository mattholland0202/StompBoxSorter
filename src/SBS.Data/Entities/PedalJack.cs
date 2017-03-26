namespace SBS.Data.Entities
{
    public class PedalJack
    {
        public virtual int PedalJackID { get; set; }
        public virtual Pedal Pedal { get; set; }
        public virtual PedalJackType Type { get; set; }
        public virtual string Name { get; set; }
    }
}
