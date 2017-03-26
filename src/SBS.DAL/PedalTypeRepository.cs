using System.Collections.Generic;
using System.Linq;
using SBS.DAL.Base;
using SBS.DAL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.DAL
{
    public class PedalTypeRepository : AbstractDALBase, IReadOnlyRepository<PedalType>
    {
        public PedalTypeRepository(SbsContext dbc) : base(dbc)
        {
        }

        public PedalType Get(int id)
        {
            var ptf = dbc.PedalType.SingleOrDefault(x => x.PedalTypeID == id);
            return ptf;
        }

        public IEnumerable<PedalType> GetAll()
        {
            var all = dbc.PedalType.AsEnumerable();
            return all;   
        }
    }
}
