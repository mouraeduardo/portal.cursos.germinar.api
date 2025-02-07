using Core.Models;
using Core.Models.DTOs;
using Core.Repositories;
using Core.Services;
using Infrastructure.Percistence.Repositories;
using Infrastructure.Utils;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool CreateUser(UserCreateDTO userDTO)
        {

            User user = new User 
            { 
                Email = userDTO.Email,
                FirstName = userDTO.FirstName,
                LastName = userDTO.LastName,
                TaxId = userDTO.TaxId,
                Salt = EncryptionFunctions.GenerateSalt(),
                CreateDate = DateTime.UtcNow,
                UpdateDate = DateTime.UtcNow,
                DeletionDate = null,
            };

            user.Password  = EncryptionFunctions.ComputeHash(userDTO.Password, user.Salt, "123", 5);
            _userRepository.Add(user);

            return true;
        }

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool Login(UserLoginDTO userLoginDTO)
        {
            User user = _userRepository.GetByEmail(userLoginDTO.Email);

            if (user == null) return false;

            string passwordEncrypted = EncryptionFunctions.ComputeHash(userLoginDTO.Password, user.Salt, "123", 5);

            if (user.Password == passwordEncrypted)
                return true;

            return false;
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
