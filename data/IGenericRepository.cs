namespace crud.data;

public interface IGenericRepository<T> where T : class
{
    Task<T?> getById(int id);

    Task<List<T>> getAll();

    Task<T> create(T entity);

    Task<T> delete(T entity);

    Task<T> update(T entity);
}