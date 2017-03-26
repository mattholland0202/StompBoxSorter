namespace SBS.Data.Entities
{
    public class AccessoryDeployment
    {
        public AccessoryDeployment(BoardDeploymentItem boardDeploymentItem,
                                   Accessory accessory)
        {
            BoardDeploymentItem = boardDeploymentItem;
            Accessory           = accessory;
        }

        public virtual int AccessoryDeploymentID { get; set; }
        public virtual BoardDeploymentItem BoardDeploymentItem { get; set; }
        public virtual Accessory Accessory { get; set; }
    }
}
