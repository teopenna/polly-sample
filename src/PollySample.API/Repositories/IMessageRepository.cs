using System.Threading.Tasks;

namespace PollySample.API.Repositories
{
    public interface IMessageRepository
    {
        Task<string> GetHelloMessage();
        Task<string> GetGoodbyeMessage();
    }
}
