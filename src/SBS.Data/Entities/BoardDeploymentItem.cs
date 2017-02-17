using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBS.Data.Entities
{
    public class BoardDeploymentItem : VersionedEntity
    {
        public virtual int BoardDeploymentItemID { get; set; }
        public virtual BoardDeployment BoardDeployment { get; set; }
        public virtual int PositionX { get; set; }
        public virtual int PositionY { get; set; }
    }
}
