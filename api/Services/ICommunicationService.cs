using System.Threading.Tasks;

namespace api.Services
{
    public interface ICommunicationService
    {
        Task RequestSong(string title);
    }
}