
using XWay_CSharp_API.DataTransferObject;

namespace XWay_CSharp_API.Services.Auth
{
    public interface IAuthService
    {
        public string GenerateToken(string id, string email, string role);
        public Task<Models.User?> AuthenticateUser(LoginModel login);

    }
}
