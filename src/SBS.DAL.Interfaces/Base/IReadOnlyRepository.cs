using System.Collections.Generic;

namespace SBS.DAL.Interfaces.Base
{
    public interface IReadOnlyRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
