namespace Repositories;

using Entities;

public interface IUserRepo {

    // List<User> getAllUsers();

    void addNewUser(User newUser);

    bool isExistingUser(User checkUser);
}