using System.Collections.Generic;
using SBS.BLL.Base;
using SBS.BLL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL
{
    public class PedalTypeFamilyBll : AbstractBLLBase, IGetEntityBLLBase<PedalTypeFamily>
    {
        public PedalTypeFamilyBll(IBLL bll) : base(bll)
        {
        }

        public PedalTypeFamily Get(int id)
        {
            var ptf = UnitOfWork.PedalTypeFamilyRepository.Get(id);
            return ptf;
        }

        public IEnumerable<PedalTypeFamily> GetAll()
        {
            var families = UnitOfWork.PedalTypeFamilyRepository.GetAll();
            return families;
        }
    }
}
