using System;
using SBS.Data.Entities;

namespace SBS.Data.Base
{
    public abstract class BoardDeploymentItem
    {
        protected BoardDeploymentItem(BoardDeployment boardDeployment,
                                      int positionX,
                                      int positionY,
                                      bool belowBoard)
        {
            BoardDeployment = boardDeployment;
            PositionX       = positionX;
            PositionY       = positionY;
            Created         = DateTime.UtcNow;
            BelowBoard      = belowBoard;
        }

        public virtual int BoardDeploymentItemID { get; set; }
        public virtual BoardDeployment BoardDeployment { get; set; }
        public virtual int PositionX { get; set; }
        public virtual int PositionY { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual bool BelowBoard { get; set; }
    }
}
