namespace crud.user.service;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public async Task<User?> getUserById(int id)
    {
        var user = await userRepository.getById(id);
        return user;
    }

    public async Task<List<User>> getUsers()
    {
        var users = await userRepository.getAll();
        return users;
    }

    public async Task<User> createUser(User user)
    {
        var createdUser = await userRepository.create(user);
        return createdUser;
    }

    public async Task<User> updateUser(User user)
    {
        var updatedUser = await userRepository.update(user);
        return updatedUser;
    }

    public async Task<User> deleteUser(User user)
    {
        var deletedUser = await userRepository.delete(user);
        return deletedUser;
    }
}