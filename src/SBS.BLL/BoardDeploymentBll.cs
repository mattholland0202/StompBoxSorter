using System;
using SBS.BLL.Base;
using SBS.BLL.Interfaces;
using SBS.BLL.Interfaces.Base;
using SBS.Data.Base;
using SBS.Data.Entities;

namespace SBS.BLL
{
    public class BoardDeploymentBll : AbstractBLLBase, IBoardDeploymentBll
    {
        public BoardDeploymentBll(IBLL bll) : base(bll)
        {
        }

        public void Add(string name, 
                        Board board,
                        User author,
                        string description)
        {
            BoardDeployment boardDeployment = new BoardDeployment(name,
                                                                  board,
                                                                  author,
                                                                  description);

            UnitOfWork.BoardDeploymentRepository.Add(boardDeployment);
        }

        public void AddAccessoryDeployment(BoardDeployment boardDeployment, 
                                           Accessory accessory, 
                                           int positionX, 
                                           int positionY,
                                           bool belowBoard = false)
        {
            AccessoryDeployment accessoryDeployment = new AccessoryDeployment(boardDeployment,
                                                                              positionX,
                                                                              positionY,
                                                                              belowBoard,
                                                                              accessory);
            UnitOfWork.AccessoryDeploymentRepository.Add(accessoryDeployment);
        }

        public void AddPedalDeployment(BoardDeployment boardDeployment, 
                                       Pedal pedal, 
                                       int positionX, 
                                       int positionY,
                                       bool belowBoard = false)
        {
            PedalDeployment pedalDeployment = new PedalDeployment(boardDeployment,
                                                                  positionX,
                                                                  positionY,
                                                                  belowBoard,
                                                                  pedal);
            UnitOfWork.PedalDeploymentRepository.Add(pedalDeployment);
        }

        public void AddPowerSupplyDeployment(BoardDeployment boardDeployment, 
                                             PowerSupply powerSupply, 
                                             int positionX, 
                                             int positionY,
                                             bool belowBoard = false)
        {
            PowerSupplyDeployment powerSupplyDeployment = new PowerSupplyDeployment(boardDeployment,
                                                                                    positionX,
                                                                                    positionY,
                                                                                    belowBoard,
                                                                                    powerSupply);
            UnitOfWork.PowerSupplyDeploymentRepository.Add(powerSupplyDeployment);
        }

        public void AddPedalDeploymentConnection(PedalDeploymentJack source, 
                                                 PedalDeploymentJack destination)
        {
            // TODO
            throw new NotImplementedException();
        }

        public void DeleteItem(BoardDeploymentItem boardDeploymentItem)
        {
            throw new NotImplementedException();
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
