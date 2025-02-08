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
        private readonly IEncryptionFunctions _encryptionFunctions;


        public UserService(IUserRepository userRepository, IEncryptionFunctions encryptionFunctions)
        {
            _userRepository = userRepository;
            _encryptionFunctions = encryptionFunctions; 
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
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

        public string Login(UserLoginDTO userLoginDTO)
        {
            User user = _userRepository.GetByEmail(userLoginDTO.Email);

            if (user == null) return null;

            string passwordEncrypted = EncryptionFunctions.ComputeHash(userLoginDTO.Password, user.Salt, "123", 5);

            if (user.Password != passwordEncrypted)
                return null;

            return _encryptionFunctions.GenerateJwtToken(user);
        }             

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
