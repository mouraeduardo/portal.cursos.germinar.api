using Core.Models;

namespace Infrastructure.Utils
{
    public interface IEncryptionFunctions
    {
        public string GenerateJwtToken(User user);
    }
}
