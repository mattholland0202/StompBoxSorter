namespace SBS.Data.Entities
{
    public class PowerSupplyOutput
    {
        public virtual int PowerSupplyOutputID { get; set; }
        public virtual PowerSupply PowerSupply { get; set; }
        public virtual int Voltage { get; set; }
        public virtual int IsDcPower { get; set; }
    }
}
