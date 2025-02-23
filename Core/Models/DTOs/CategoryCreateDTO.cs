using System.ComponentModel.DataAnnotations;

namespace Core.Models.DTOs;

public class CategoryCreateDTO
{
    [Required(ErrorMessage = "Nome é obrigatório.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Descrição é obrigatório.")]
    public string Description { get; set; }
}
