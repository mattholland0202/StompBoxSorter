namespace SBS.Data.Entities
{
    public class PedalPowerConnection
    {
        public virtual int PedalPowerConnectionID { get; set; }
        public virtual Pedal Pedal { get; set; }
        public virtual int Voltage { get; set; }
        public virtual bool IsDcPower { get; set; }
        public virtual bool HasBatteryConnection { get; set; }
        public virtual int? CurrentDraw { get; set; }
    }
}
