namespace SBS.Data.Entities
{
    public class PedalImage
    {
        public virtual int PedalImageID { get; set; }
        public virtual Pedal Pedal { get; set; }
        public virtual byte[] Image { get; set; }
        public virtual bool IsMain { get; set; }
    }
}
