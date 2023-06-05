namespace XWay_CSharp_API.Services.Email
{

    public interface IEmailService
    {
        public Task<bool> SendEmailFromGmail(string toEmail, string subject, string body);
    }

}
