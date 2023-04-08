using crud.user;
using Microsoft.EntityFrameworkCore;

namespace crud.data;

public class CrudContext : DbContext
{
    public CrudContext(DbContextOptions<CrudContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
}