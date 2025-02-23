using Core.Models;
using Core.Repositories;
using Infrastructure.Percistence.Context;

namespace Infrastructure.Percistence.Repositories
{
    public class CourseRepository : BaseRepository, ICourseRepository
    {
        public CourseRepository(AppDbContext context) : base(context) { }

        public void Insert(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void Update(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }

        public List<Course> GetAll() => _context.Courses.ToList();

        public Course GetById(int id) => _context.Courses.Find(id);
    }
}
