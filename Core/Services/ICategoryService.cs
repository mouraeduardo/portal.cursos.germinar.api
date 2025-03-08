using Core.Models.DTOs;

namespace Core.Services;

public interface ICategoryService
{
    public void Create(CategoryCreateDTO categoryCreateDTO);
    public void Update(CategoryCreateDTO categoryCreateDTO, int id);
    public void Delete(int id);
}
