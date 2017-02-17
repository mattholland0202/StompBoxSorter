using SBS.BLL.Interfaces.Base;
using SBS.Data.Entities;

namespace SBS.BLL.Interfaces
{
    public interface IBoardBll : IGetEntityBLLBase<Board>, IUpdateDeleteEntityBLLBase<Board>
    {
        void Add(string name,
                 string shortName,
                 Manufacturer manufacturer,
                 int width,
                 int height,
                 int? weight = null);

        void Verify(Board board);
    }
}
