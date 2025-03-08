using Core.Models;
using Core.Models.DTOs;
using Core.Repositories;
using Core.Services;
using Infrastructure.Percistence.Repositories;

namespace Infrastructure.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository; 
        }

        public void Create(CourseCreateDTO courseCreateDTO)
        {
            try
            {
                Course course = new Course() 
                { 
                    Name = courseCreateDTO.Name,
                    Description = courseCreateDTO.Description,
                    
                };

                _courseRepository.Insert(course);
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
                //_courseRepository.Update();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(CourseCreateDTO courseCreateDTO, int id)
        {
            try
            {
                Course course = _courseRepository.GetById(id);

                course.Name = courseCreateDTO.Name;
                course.Description = courseCreateDTO.Description;
                course.Difficulty = courseCreateDTO.Difficulty;
                course.UpdateDate = DateTime.UtcNow;

                _courseRepository.Update(course);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
