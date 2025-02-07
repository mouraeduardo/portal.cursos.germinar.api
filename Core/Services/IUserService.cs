using Core.Models;
using Core.Models.DTOs;


namespace Core.Services
{
    public interface IUserService
    {
        public bool Login(UserLoginDTO user);
        public bool CreateUser(UserCreateDTO user);
        public bool UpdateUser(User user);
        public bool DeleteUser(User user);
    }
}
