using XWay_CSharp_API.DataTransferObject;

namespace XWay_CSharp_API.Services.User
{
    public interface IUserService
    {
        public Task<XWay_CSharp_API.Models.User?> Get(int id);
        public Task<XWay_CSharp_API.Models.User?> ForgotPassword(ForgotPasswordModel forgotPassword);
        public Task<bool> ChangePassword(int userId, ChangePasswordModel changePassword);
        public Task<bool> Register(RegisterModel addUserModel);
        public Task<bool> DeleteAUser(string email);



    }
}
