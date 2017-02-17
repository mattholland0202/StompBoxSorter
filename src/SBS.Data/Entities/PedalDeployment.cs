using System.Collections.Generic;

namespace SBS.Data.Entities
{
    public class PedalDeployment : VersionedEntity
    {
        public virtual int PedalDeploymentID { get; set; }
        public virtual BoardDeploymentItem BoardDeploymentItem { get; set; }
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
