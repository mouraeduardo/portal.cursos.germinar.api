using Core.Models;
using Core.Models.DTOs;


namespace Core.Services
{
    public interface IUserService
    {
        public string Login(UserLoginDTO user);
        public List<User> GetAllUsers();
        public bool CreateUser(UserCreateDTO user);
        public bool UpdateUser(User user);
        public bool DeleteUser(User user);
    }
}
