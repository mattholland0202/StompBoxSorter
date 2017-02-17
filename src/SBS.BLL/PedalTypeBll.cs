using System.Collections.Generic;
using SBS.BLL.Base;
using SBS.BLL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL
{
    public class PedalTypeBll : AbstractBLLBase, IGetEntityBLLBase<PedalType>
    {
        public PedalTypeBll(IBLL bll) : base(bll)
        {
        }

        /// <summary>
        /// Get a Pedal Type matching the specified ID
        /// </summary>
        /// <param name="id">The ID of the Pedal Type to retrieve</param>
        /// <returns>The Pedal Type matching the specified ID</returns>
        public PedalType Get(int id)
        {
            var pt = UnitOfWork.PedalTypeRepository.Get(id);
            return pt;
        }

        /// <summary>
        /// Get a collection of all Pedal Types
        /// </summary>
        /// <returns>A collection of all Pedal Types</returns>
        public IEnumerable<PedalType> GetAll()
        {
            var types = UnitOfWork.PedalTypeRepository.GetAll();
            return types;
        }
    }
}
