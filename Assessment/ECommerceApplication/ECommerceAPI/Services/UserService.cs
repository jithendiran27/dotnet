namespace Services;

using Entities;
using Repositories;

public class UserService : IUserService
{
    private readonly IUserRepo _userRepo;

    public UserService(IUserRepo userRepo) {
        _userRepo = userRepo;
    }

    public void addNewUser(User newUser) {
        _userRepo.addNewUser(newUser);
    }

    public bool isExistingUser(User user) {
        return _userRepo.isExistingUser(user);
    }
}