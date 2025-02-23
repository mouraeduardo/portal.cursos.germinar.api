using Core.Models;
using Core.Models.DTOs;
using Core.Repositories;
using Core.Services;

namespace Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }

        public void Create(CategoryCreateDTO categoryCreateDTO)
        {
            try
            {
                Category category = new Category
                {
                    Name = categoryCreateDTO.Name,
                    Description = categoryCreateDTO.Description,
                    CreateDate = DateTime.UtcNow,
                    UpdateDate = DateTime.UtcNow,
                    DeletionDate = null
                };

                _categoryRepository.Insert(category);
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
                Category category = new Category
                {
                    Id = id,
                    UpdateDate = DateTime.Now,
                    DeletionDate = DateTime.Now
                };

                _categoryRepository.Update(category);
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
                Category category = new Category
                {
                    Id = id,
                    Name = categoryCreateDTO.Name,
                    Description = categoryCreateDTO.Description,
                    UpdateDate = DateTime.UtcNow,
                    DeletionDate = null
                };

                _categoryRepository.Update(category);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
