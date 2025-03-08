using Core.Models.DTOs;

namespace Core.Services;

public interface ICourseService
{
    public void Create(CourseCreateDTO categoryCreateDTO);
    public void Update(CourseCreateDTO categoryCreateDTO, int id);
    public void Delete(int id);
}
