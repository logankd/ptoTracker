using System.Threading.Tasks;

namespace PtoTracker.WebServices
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
