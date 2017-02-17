namespace SBS.Data.Entities
{
    public class PowerConnection : VersionedEntity
    {
        public virtual int PowerConnectionID { get; set; }
        public virtual int Voltage { get; set; }
        public virtual int IsDcPower { get; set; }
    }
}
