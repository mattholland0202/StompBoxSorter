using SBS.Data.Base;

namespace SBS.Data.Entities
{
    public class PowerSupplyDeployment : BoardDeploymentItem
    {
        public PowerSupplyDeployment(BoardDeployment boardDeployment,
                                     int positionX,
                                     int positionY,
                                     bool belowBoard,
                                     PowerSupply powerSupply) : base(boardDeployment, positionX, positionY, belowBoard)
        {
            PowerSupply = powerSupply;
        }

        public virtual int PowerSupplyDeploymentID { get; set; }
        public virtual PowerSupply PowerSupply { get; set; }
    }
}
