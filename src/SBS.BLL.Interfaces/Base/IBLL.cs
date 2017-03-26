using SBS.DAL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL.Interfaces.Base
{
    public interface IBLL
    {
        IUnitOfWork UnitOfWork { get; }

        IAccessoryBll Accessories { get; }
        IBoardBll Boards { get; }
        IPedalBll Pedals { get; }
        IGetEntityBLLBase<PedalType> PedalTypes { get; }
    }
}
