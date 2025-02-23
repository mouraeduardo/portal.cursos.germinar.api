using Core.Models;
using Core.Models.DTOs;

namespace Core.Services;

public interface IUserService
{
    public List<User> GetAllUsers();
    //public User GetByEmail(string email);
    public bool CreateUser(UserCreateDTO user);
    public string Login(UserLoginDTO userLoginDTO);
    public bool UpdateUser(User user);
}
