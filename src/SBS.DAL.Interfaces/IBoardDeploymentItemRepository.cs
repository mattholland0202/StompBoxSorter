using SBS.Data.Entities;

namespace SBS.DAL.Interfaces
{
    public interface IBoardDeploymentItemRepository
    {
        void Add(BoardDeploymentItem boardDeploymentItem);
        void Delete(BoardDeploymentItem boardDeploymentItem);
    }
}
