using System;
using System.Collections.Generic;
using SBS.Data.Base;

namespace SBS.Data.Entities
{
    public class BoardDeployment
    {
        public BoardDeployment(string name,
                               Board board,
                               User author,
                               string description)
        {
            Name        = name;
            Board       = board;
            Author      = author;
            Description = description;
            Created     = DateTime.UtcNow;
            LastUpdated = DateTime.UtcNow;
        }

        public virtual int BoardDeploymentID { get; set; }
        public virtual string Name { get; set; }
        public virtual Board Board { get; set; }
        public virtual User Author { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual DateTime LastUpdated { get; set; }

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
