using SBS.BLL.Interfaces.Base;
using SBS.Data.Base;
using SBS.Data.Entities;

namespace SBS.BLL.Interfaces
{
    public interface IBoardDeploymentBll : IGetSingleEntityOnlyBllBase<BoardDeployment>, IUpdateDeleteEntityBLLBase<BoardDeployment>
    {
        /// <summary>
        /// Add a new Board Deployment
        /// </summary>
        /// <param name="name">The Name of the Board Deployment</param>
        /// <param name="board">The Board that this Deployment is based on</param>
        /// <param name="author">The User who created this Deployment</param>
        /// <param name="description">A free-text description of this Deployment</param>
        void Add(string name,
                 Board board,
                 User author,
                 string description);

        /// <summary>
        /// Add a Pedal Deployment to the supplied Board Deployment at the specified position
        /// </summary>
        /// <param name="boardDeployment">The Board Deployment to add to</param>
        /// <param name="pedal">The Pedal to add a Deployment of</param>
        /// <param name="positionX">The X-axis position of the Deployment</param>
        /// <param name="positionY">The Y-axis position of the Deployment</param>
        /// <param name="belowBoard">Is the Deployment an item which is placed below the Board</param>
        void AddPedalDeployment(BoardDeployment boardDeployment,
                                Pedal pedal,
                                int positionX,
                                int positionY,
                                bool belowBoard = false);

        /// <summary>
        /// Add an Accessory Deployment to the supplied Board Deployment at the specified position
        /// </summary>
        /// <param name="boardDeployment">The Board Deployment to add to</param>
        /// <param name="accessory">THe Accessory to add a Deployment of</param>
        /// <param name="positionX">The X-axis position of the Deployment</param>
        /// <param name="positionY">The Y-axis position of the Deployment</param>
        /// <param name="belowBoard">Is the Deployment an item which is placed below the Board</param>
        void AddAccessoryDeployment(BoardDeployment boardDeployment,
                                    Accessory accessory,
                                    int positionX,
                                    int positionY,
                                    bool belowBoard = false);

        /// <summary>
        /// Add a Power Supply Deployment to the supplied Board Deployment at the specified position
        /// </summary>
        /// <param name="boardDeployment">The Board Deployment to add to</param>
        /// <param name="powerSupply">The Power Supply to add a Deployment of</param>
        /// <param name="positionX">The X-axis position of the Deployment</param>
        /// <param name="positionY">The Y-axis position of the Deployment</param>
        /// <param name="belowBoard">Is the Deployment an item which is placed below the Board</param>
        void AddPowerSupplyDeployment(BoardDeployment boardDeployment,
                                      PowerSupply powerSupply,
                                      int positionX,
                                      int positionY,
                                      bool belowBoard = false);

        /// <summary>
        /// Add a Connection between two Pedal Deployment Jacks
        /// </summary>
        /// <param name="source">The Source of the Connection</param>
        /// <param name="destination">The Destination of the Connection</param>
        void AddPedalDeploymentConnection(PedalDeploymentJack source,
                                          PedalDeploymentJack destination);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="boardDeploymentItem"></param>
        void DeleteItem(BoardDeploymentItem boardDeploymentItem);
    }
}
