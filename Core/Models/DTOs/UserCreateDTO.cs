using System.ComponentModel.DataAnnotations;
using static Core.Resources.Enums.Enums;

namespace Core.Models.DTOs;

public class UserCreateDTO
{
    [Required(ErrorMessage = "Nome é obrigatório.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Sobrenome é obrigatório.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Email é obrigatório.")]
    [EmailAddress(ErrorMessage = "Informe um email válido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Data de nascimento é obrigatório.")]
    public DateTime DateOfBirth { get; set; }
    public string Registration { get; set; }

    [Required(ErrorMessage = "Senha é obrigatório")]
    [StringLength(16,MinimumLength=8, ErrorMessage = "Senha deve conter entre 8 e 16 caracteres")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Confirmação de senha é obrigatório.")]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    public string TaxId { get; set; }
}
