using SBS.DAL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.DAL.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private IReadWriteRepository<Accessory> accessoryRepository;
        private IReadWriteRepository<Board> boardRepository;
        private IReadWriteRepository<Pedal> pedalRepository;
        private IReadOnlyRepository<PedalTypeFamily> pedalTypeFamilyRepository;
        private IReadOnlyRepository<PedalType> pedalTypeRepository;

        public UnitOfWork()
        {

        }

        public IReadWriteRepository<Accessory> AccessoryRepository => accessoryRepository;
        public IReadWriteRepository<Board> BoardRepository => boardRepository;
        public IReadWriteRepository<Pedal> PedalRepository => pedalRepository;
        public IReadOnlyRepository<PedalTypeFamily> PedalTypeFamilyRepository => pedalTypeFamilyRepository;
        public IReadOnlyRepository<PedalType> PedalTypeRepository => pedalTypeRepository;

        public void SaveChanges()
        {

        }
    }
}
