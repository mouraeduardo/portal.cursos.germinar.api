using Core.Models;

namespace Core.Repositories
{
    public interface IUserRepository
    {
        public List<User> GetAllUsers();
        public User GetByEmail(string email);
        public User GetById(int id);
        public void Update(User user);
        public void Delete(User user);
        public void Add(User user);
    }
}
