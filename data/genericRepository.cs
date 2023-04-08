using Microsoft.EntityFrameworkCore;

namespace crud.data;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly CrudContext context;
    private DbSet<T> entities;

    public GenericRepository(CrudContext context)
    {
        this.context = context;
        entities = this.context.Set<T>();
    }

    public async Task<List<T>> getAll()
    {
        return await entities.ToListAsync();
    }

    public async Task<T?> getById(int id)
    {
        return await entities.FindAsync(id);
    }

    public async Task<T> create(T entity)
    {
        await entities.AddAsync(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> update(T entity)
    {
        context.Update<T>(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> delete(T entity)
    {
        context.Remove<T>(entity);
        await context.SaveChangesAsync();
        return entity;
    }
}