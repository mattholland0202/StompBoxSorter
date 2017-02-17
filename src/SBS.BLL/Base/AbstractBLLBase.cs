using SBS.BLL.Interfaces.Base;
using SBS.DAL.Interfaces.Base;

namespace SBS.BLL.Base
{
    public abstract class AbstractBLLBase
    {
        internal IBLL BLL;
        internal IUnitOfWork UnitOfWork;

        public AbstractBLLBase(IBLL bll)
        {
            BLL = bll;
            UnitOfWork = bll.UnitOfWork;
        }
    }
}
