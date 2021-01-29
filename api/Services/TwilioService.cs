using System.Threading.Tasks;
using api.Models;
using Microsoft.Extensions.Options;

namespace api.Services
{
    public class TwilioService : ICommunicationService
    {
        private readonly TwilioOptions _options;

        public TwilioService(IOptions<TwilioOptions> options) => _options = options.Value;

        public Task RequestSong(string title)
        {
            throw new System.NotImplementedException();
        }
    }
}