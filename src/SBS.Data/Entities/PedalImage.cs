namespace SBS.Data.Entities
{
    public class PedalImage
    {
        public virtual int PedalImageID { get; set; }
        public virtual Pedal Pedal { get; set; }
        public virtual byte[] Image { get; set; }
        public virtual bool IsMainImage { get; set; }
        public virtual User Creator { get; set; }
        public virtual bool IsValidated { get; set; }
    }
}
