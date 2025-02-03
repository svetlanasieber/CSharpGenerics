public interface IRepository<T>
{
    void Add(T entity);
    IEnumerable<T> GetAll();
    // ... Other CRUD operations
}
