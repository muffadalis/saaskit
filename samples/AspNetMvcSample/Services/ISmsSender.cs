using System.Threading.Tasks;

namespace AspNetMvcSample.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
