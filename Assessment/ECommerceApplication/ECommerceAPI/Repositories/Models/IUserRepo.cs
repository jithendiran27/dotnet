namespace Repositories;

using Entities;

public interface IUserRepo {

    void addNewUser(User newUser);

    bool isExistingUser(User checkUser);
}