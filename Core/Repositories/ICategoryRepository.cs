using Core.Models;

namespace Core.Repositories
{
    public interface ICategoryRepository
    {
        public void Insert(Category category);
        public void Update(Category category);
        public Category GetById(int id);
        public List<Category> GetAll();
    }
}
