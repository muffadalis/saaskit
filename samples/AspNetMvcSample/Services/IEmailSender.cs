using System.Threading.Tasks;

namespace AspNetMvcSample.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
