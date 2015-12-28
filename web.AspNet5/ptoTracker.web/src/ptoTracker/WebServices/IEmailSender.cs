using System.Threading.Tasks;

namespace PtoTracker.WebServices
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
