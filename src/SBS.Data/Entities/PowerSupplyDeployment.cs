namespace SBS.Data.Entities
{
    public class PowerSupplyDeployment
    {
        public virtual int PowerSupplyDeploymentID { get; set; }
        public virtual BoardDeploymentItem BoardDeploymentItem { get; set; }
        public virtual PowerSupply PowerSupply { get; set; }
    }
}
