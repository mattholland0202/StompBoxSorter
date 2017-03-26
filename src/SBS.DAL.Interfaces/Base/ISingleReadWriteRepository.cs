namespace SBS.DAL.Interfaces.Base
{
    public interface ISingleReadWriteRepository<T>
    {
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
    }
}
