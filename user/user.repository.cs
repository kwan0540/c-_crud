using crud.data;

namespace crud.user;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(CrudContext context) : base(context)
    {
    }
}