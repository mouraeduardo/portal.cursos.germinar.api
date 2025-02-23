using Core.Models;
using Core.Repositories;
using Infrastructure.Percistence.Context;

namespace Infrastructure.Percistence.Repositories;

public class CategoryRepository : BaseRepository, ICategoryRepository
{
    public CategoryRepository(AppDbContext context) : base(context){}

    public void Insert(Category category) 
    {
        _context.Categories.Add(category);
        _context.SaveChanges();
    }
    public void Update(Category category) 
    {
        _context.Categories.Update(category);
        _context.SaveChanges();
    }
    public Category GetById(int id) 
    {
        return _context.Categories.Find(id);
    }
    public List<Category> GetAll() 
    {
        return _context.Categories.ToList();
    }

}
