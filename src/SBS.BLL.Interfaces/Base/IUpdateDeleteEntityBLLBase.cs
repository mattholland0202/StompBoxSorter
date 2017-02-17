namespace SBS.BLL.Interfaces.Base
{
    public interface IUpdateDeleteEntityBLLBase<T>
    {
        void Delete(T entity);

        void Update(T entity);
    }
}
