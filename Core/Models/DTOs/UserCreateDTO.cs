namespace Core.Models.DTOs
{
    public class UserCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
        public string TaxId { get; set; }
    }
}
