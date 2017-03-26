namespace SBS.Data.Entities
{
    public class PedalPowerConnection
    {
        public virtual int PowerConnectionID { get; set; }
        public virtual int Voltage { get; set; }
        public virtual int IsDcPower { get; set; }
    }
}
