using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBS.Data.Entities
{
    public class AccessoryDeployment : VersionedEntity
    {
        public virtual int AccessoryDeploymentID { get; set; }
        public virtual BoardDeploymentItem BoardDeploymentItem { get; set; }
        public virtual Accessory Accessory { get; set; }
    }
}
