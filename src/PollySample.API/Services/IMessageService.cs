using System.Threading.Tasks;

namespace PollySample.API.Services
{
    public interface IMessageService
    {
        Task<string> GetHelloMessage();
        Task<string> GetGoodbyeMessage();
    }
}
