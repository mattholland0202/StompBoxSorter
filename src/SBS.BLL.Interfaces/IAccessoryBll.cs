using SBS.BLL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL.Interfaces
{
    public interface IAccessoryBll : IGetEntityBLLBase<Accessory>, IUpdateDeleteEntityBLLBase<Accessory>
    {
        void Add(string name,
                 int width,
                 int depth,
                 int height,
                 int? weight = null);
        void Verify(Accessory accessory);
    }
}
