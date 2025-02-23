using System.ComponentModel.DataAnnotations;

namespace Core.Models.DTOs;

public class UserLoginDTO
{
    [Required(ErrorMessage = "Por favor, insira um Email")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Por favor, insira uma senha")]
    public string Password { get; set; }
}
