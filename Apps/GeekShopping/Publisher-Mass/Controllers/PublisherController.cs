using MassTransit;
using MensageryLib;
using Microsoft.AspNetCore.Mvc;

namespace Publisher_Mass.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PublisherController: ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public PublisherController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }

        [HttpPost(Name = "Published")]
        public async Task<IActionResult> Post()
        {
            await _publishEndpoint.Publish(new OrderCreated(1, 2, 3));

            return Ok();
        }
    }
}
