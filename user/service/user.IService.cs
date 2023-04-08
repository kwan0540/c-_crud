namespace crud.user.service;

public interface IUserService
{
    public Task<User?> getUserById(int id);

    public Task<List<User>> getUsers();

    public Task<User> updateUser(User user);

    public Task<User> deleteUser(User user);

    public Task<User> createUser(User user);
}