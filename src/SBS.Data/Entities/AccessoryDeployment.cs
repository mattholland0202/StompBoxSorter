using SBS.Data.Base;

namespace SBS.Data.Entities
{
    public class AccessoryDeployment : BoardDeploymentItem
    {
        public AccessoryDeployment(BoardDeployment boardDeployment,
                                   int positionX,
                                   int positionY,
                                   bool belowBoard,
                                   Accessory accessory) : base(boardDeployment, positionX, positionY, belowBoard)
        {
            Accessory = accessory;
        }

        public virtual int AccessoryDeploymentID { get; set; }
        public virtual Accessory Accessory { get; set; }
    }
}
