using static Core.Resources.Enums.Enums;

namespace Core.Models
{
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Registration { get; set; }
        public string TaxId { get; set; }
        public UserRole Role { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
    }
}
