using Core.Models.DTOs;
using Core.Services;

namespace Infrastructure.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseService _courseService;

        public CourseService(ICourseService courseService)
        {
            _courseService = courseService; 
        }

        public void Create(CategoryCreateDTO categoryCreateDTO)
        {
            try
            {
                _courseService.Create(categoryCreateDTO);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            try
            {
                _courseService.Delete(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(CategoryCreateDTO categoryCreateDTO, int id)
        {
            try
            {
                _courseService.Update(categoryCreateDTO, id);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
