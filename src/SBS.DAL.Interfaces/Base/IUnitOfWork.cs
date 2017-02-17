using SBS.Data.Entities;

namespace SBS.DAL.Interfaces.Base
{
    public interface IUnitOfWork
    {
        IReadWriteRepository<Accessory> AccessoryRepository { get; }
        IReadWriteRepository<Board> BoardRepository { get; }
        IReadWriteRepository<Pedal> PedalRepository { get; }
        IReadOnlyRepository<PedalTypeFamily> PedalTypeFamilyRepository { get; }
        IReadOnlyRepository<PedalType> PedalTypeRepository { get; }

        void SaveChanges();
    }
}
