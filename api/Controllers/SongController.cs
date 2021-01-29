using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twilio.TwiML;
using Twilio.TwiML.Messaging;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SongController: ControllerBase 
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] string body)
        {
            // Acknowledge the incoming SMS
            // Look up the song request Body and queue the result 
            // Respond to the SMS
            var response = new MessagingResponse();
            var message = new Message();
            message.Body($"Hey there. We got your song request {body}. Sit tight we're about to play it shortly!");
            response.Append(message);
            return new ContentResult {Content =response.ToString(), ContentType = "application/xml", StatusCode = 200 };
        }
    }
}