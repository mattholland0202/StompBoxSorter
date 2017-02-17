using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBS.Data.Entities
{
    public class CustomPedalDeployment : VersionedEntity
    {
        public virtual int CustomPedalDeploymentID { get; set; }
        public virtual BoardDeploymentItem BoardDeploymentItem { get; set; }
        public virtual string Name { get; set; }
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public virtual int Depth { get; set; }

        private readonly IList<CustomPedalDeploymentJack> jacks = new List<CustomPedalDeploymentJack>();
        public virtual IList<CustomPedalDeploymentJack> Jacks
        {
            get
            {
                return jacks;
            }
        }
    }
}
