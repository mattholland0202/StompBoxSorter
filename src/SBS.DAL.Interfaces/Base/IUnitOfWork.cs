using SBS.DAL.Interfaces;
using SBS.Data.Entities;

namespace SBS.DAL.Interfaces.Base
{
    public interface IUnitOfWork
    {
        IReadWriteRepository<Accessory> AccessoryRepository { get; }
        IReadWriteRepository<Board> BoardRepository { get; }
        ISingleReadWriteRepository<BoardDeployment> BoardDeploymentRepository { get; }
        IBoardDeploymentItemRepository BoardDeploymentItemRepository { get; }
        IReadWriteRepository<Pedal> PedalRepository { get; }
        IReadOnlyRepository<PedalType> PedalTypeRepository { get; }

        void SaveChanges();
    }
}
