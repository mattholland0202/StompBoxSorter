using SBS.DAL.Interfaces;
using SBS.Data.Entities;

namespace SBS.DAL.Interfaces.Base
{
    public interface IUnitOfWork
    {
        IReadWriteRepository<Accessory> AccessoryRepository { get; }
        ISingleReadWriteRepository<AccessoryDeployment> AccessoryDeploymentRepository { get; }
        IReadWriteRepository<Board> BoardRepository { get; }
        ISingleReadWriteRepository<BoardDeployment> BoardDeploymentRepository { get; }
        IReadWriteRepository<Manufacturer> ManufacturerRepository { get; }
        IReadWriteRepository<Pedal> PedalRepository { get; }
        IReadOnlyRepository<PedalType> PedalTypeRepository { get; }
        ISingleReadWriteRepository<PedalDeployment> PedalDeploymentRepository { get; }
        ISingleReadWriteRepository<PowerSupplyDeployment> PowerSupplyDeploymentRepository { get; }

        void SaveChanges();
    }
}
