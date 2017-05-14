using System.Collections.Generic;
using SBS.Data.Base;

namespace SBS.Data.Entities
{
    public class PedalDeployment : BoardDeploymentItem
    {
        public PedalDeployment(BoardDeployment boardDeployment,
                               int positionX,
                               int positionY,
                               bool belowBoard,
                               Pedal pedal) : base(boardDeployment, positionX, positionY, belowBoard)
        {
            Pedal = pedal;
        }

        public virtual int PedalDeploymentID { get; set; }
        public virtual Pedal Pedal { get; set; }

        private readonly IList<PedalDeploymentJack> jacks = new List<PedalDeploymentJack>();
        public virtual IList<PedalDeploymentJack> Jacks
        {
            get
            {
                return jacks;
            }
        }
    }
}
