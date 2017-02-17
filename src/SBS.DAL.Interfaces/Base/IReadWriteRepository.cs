using System.Collections.Generic;

namespace SBS.DAL.Interfaces.Base
{
    public interface IReadWriteRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
    }
}
