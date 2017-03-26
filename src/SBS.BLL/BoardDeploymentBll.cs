using System;
using SBS.BLL.Base;
using SBS.BLL.Interfaces;
using SBS.BLL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL
{
    public class BoardDeploymentBll : AbstractBLLBase, IBoardDeploymentBll
    {
        public BoardDeploymentBll(IBLL bll) : base(bll)
        {
        }

        public void Add(string name, 
                        Board board)
        {
            BoardDeployment boardDeployment = new BoardDeployment(name,
                                                                  board);

            UnitOfWork.BoardDeploymentRepository.Add(boardDeployment);
        }

        public void AddAccessoryDeployment(BoardDeployment boardDeployment, 
                                           Accessory accessory, 
                                           int positionX, 
                                           int positionY)
        {
            BoardDeploymentItem item = new BoardDeploymentItem(boardDeployment,
                                                               positionX,
                                                               positionY);

            AccessoryDeployment accessoryDeployment = new AccessoryDeployment(item,
                                                                              accessory);
        }

        public void AddPedalDeployment(BoardDeployment boardDeployment, 
                                       Pedal pedal, 
                                       int positionX, 
                                       int positionY)
        {
            BoardDeploymentItem item = new BoardDeploymentItem(boardDeployment,
                                                               positionX,
                                                               positionY);

            throw new NotImplementedException();
        }

        public void AddPedalDeploymentConnection(PedalDeploymentJack source, 
                                                 PedalDeploymentJack destination)
        {
            // TODO: Change this. Connection as own entity?
            source.ConnectedTo = destination;
            destination.ConnectedTo = source;
        }

        public void AddPowerSupplyDeployment(BoardDeployment boardDeployment, 
                                             PowerSupply powerSupply, 
                                             int positionX, 
                                             int positionY)
        {
            BoardDeploymentItem item = new BoardDeploymentItem(boardDeployment,
                                                               positionX,
                                                               positionY);

            throw new NotImplementedException();
        }

        public void DeleteItem(BoardDeploymentItem boardDeploymentItem)
        {
            UnitOfWork.BoardDeploymentItemRepository.Delete(boardDeploymentItem);
        }

        public void Delete(BoardDeployment entity)
        {
            UnitOfWork.BoardDeploymentRepository.Delete(entity);
        }

        public BoardDeployment Get(int id)
        {
            var boardDeployment = UnitOfWork.BoardDeploymentRepository.Get(id);
            return boardDeployment;
        }

        public void Update(BoardDeployment entity)
        {
            UnitOfWork.SaveChanges();
        }
    }
}
