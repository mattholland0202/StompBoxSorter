using SBS.DAL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.DAL.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private IReadWriteRepository<Accessory> accessoryRepository;
        private ISingleReadWriteRepository<AccessoryDeployment> accessoryDeploymentRepository;
        private IReadWriteRepository<Board> boardRepository;
        private ISingleReadWriteRepository<BoardDeployment> boardDeploymentRepository;
        private IReadWriteRepository<Manufacturer> manufacturerRepository;
        private IReadWriteRepository<Pedal> pedalRepository;
        private ISingleReadWriteRepository<PedalDeployment> pedalDeploymentRepository;
        private IReadOnlyRepository<PedalType> pedalTypeRepository;
        private ISingleReadWriteRepository<PowerSupplyDeployment> powerSupplyDeploymentRepository;

        public UnitOfWork()
        {
            SbsContext dbc = new SbsContext();

            pedalTypeRepository = new PedalTypeRepository(dbc);
        }

        public IReadWriteRepository<Accessory> AccessoryRepository => accessoryRepository;
        public ISingleReadWriteRepository<AccessoryDeployment> AccessoryDeploymentRepository => accessoryDeploymentRepository;
        public IReadWriteRepository<Board> BoardRepository => boardRepository;
        public ISingleReadWriteRepository<BoardDeployment> BoardDeploymentRepository => boardDeploymentRepository;
        public IReadWriteRepository<Manufacturer> ManufacturerRepository => manufacturerRepository;
        public IReadWriteRepository<Pedal> PedalRepository => pedalRepository;
        public ISingleReadWriteRepository<PedalDeployment> PedalDeploymentRepository => pedalDeploymentRepository;
        public IReadOnlyRepository<PedalType> PedalTypeRepository => pedalTypeRepository;
        public ISingleReadWriteRepository<PowerSupplyDeployment> PowerSupplyDeploymentRepository => powerSupplyDeploymentRepository;

        public void SaveChanges()
        {
            
        }
    }
}
