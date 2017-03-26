using SBS.DAL.Interfaces;
using SBS.DAL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.DAL.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private IReadWriteRepository<Accessory> accessoryRepository;
        private IReadWriteRepository<Board> boardRepository;
        private ISingleReadWriteRepository<BoardDeployment> boardDeploymentRepository;
        private IBoardDeploymentItemRepository boardDeploymentItemRepository;
        private IReadWriteRepository<Pedal> pedalRepository;
        private IReadOnlyRepository<PedalType> pedalTypeRepository;

        public UnitOfWork()
        {
            SbsContext dbc = new SbsContext();

            pedalTypeRepository = new PedalTypeRepository(dbc);
        }

        public IReadWriteRepository<Accessory> AccessoryRepository => accessoryRepository;
        public IReadWriteRepository<Board> BoardRepository => boardRepository;
        public ISingleReadWriteRepository<BoardDeployment> BoardDeploymentRepository => boardDeploymentRepository;
        public IBoardDeploymentItemRepository BoardDeploymentItemRepository => boardDeploymentItemRepository;
        public IReadWriteRepository<Pedal> PedalRepository => pedalRepository;
        public IReadOnlyRepository<PedalType> PedalTypeRepository => pedalTypeRepository;

        public void SaveChanges()
        {

        }
    }
}
