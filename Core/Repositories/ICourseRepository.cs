using Core.Models;

namespace Core.Repositories
{
    public interface ICourseRepository
    {
        public void Insert(Course course);
        public void Update(Course course);
        public Course GetById(int id);
        public List<Course> GetAll();
    }
}
