using Core.Models;
using Core.Repositories;
using Infrastructure.Percistence.Context;

namespace Infrastructure.Percistence.Repositories;

public class UserRepository : BaseRepository, IUserRepository
{

    public UserRepository(AppDbContext context) : base(context) { }

    public void Update(User user)
    {
        try
        {
            _context.users.Update(user);
        }
        catch (Exception)
        {
            throw;
        }

    }
    public void Delete(User user)
    {
        _context.users.Remove(user);
    }
    public void Add(User user)
    {
        try
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public List<User> GetAllUsers()
    {
        return _context.users.ToList();
    }

    public User GetById(int id)
    {
        return _context.users.Find(id);
    }

    public User GetByEmail(string email)
    {
        return _context.users.FirstOrDefault(x => x.Email == email);

    }

}
