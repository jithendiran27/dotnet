namespace Services;

using Entities;

public interface IUserService {
    void addNewUser(User user);

    bool isExistingUser(User user);
}