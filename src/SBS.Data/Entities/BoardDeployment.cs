using System.Collections.Generic;

namespace SBS.Data.Entities
{
    public class BoardDeployment : VersionedEntity
    {
        public virtual int BoardDeploymentID { get; set; }
        public virtual string Name { get; set; }
        public virtual Board Board { get; set; }

        private readonly IList<BoardDeploymentItem> items = new List<BoardDeploymentItem>();
        public virtual IList<BoardDeploymentItem> Items
        {
            get
            {
                return items;
            }
        }
    }
}
