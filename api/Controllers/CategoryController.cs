using Core.Models;
using Core.Models.DTOs;
using Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("CreateCategory"), Authorize]
        public IActionResult CreateCategory([FromBody] CategoryCreateDTO categoryCreateDTO)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _categoryService.Create(categoryCreateDTO); 

                return Ok("Categoria criada com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("UpdateCategory"), Authorize]
        public IActionResult UpdateCategory([FromBody] CategoryCreateDTO categoryCreateDTO, [FromQuery] int id)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _categoryService.Update(categoryCreateDTO, id);

                return Ok("Categoria criada com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
