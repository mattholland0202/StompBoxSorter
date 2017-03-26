namespace SBS.Data.Entities
{
    public class BoardDeploymentItem
    {
        public BoardDeploymentItem(BoardDeployment boardDeployment,
                                   int positionX,
                                   int positionY)
        {
            BoardDeployment = boardDeployment;
            PositionX       = positionX;
            PositionY       = positionY;
        }

        public virtual int BoardDeploymentItemID { get; set; }
        public virtual BoardDeployment BoardDeployment { get; set; }
        public virtual int PositionX { get; set; }
        public virtual int PositionY { get; set; }
    }
}
