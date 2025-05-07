using MassTransit;
using MensageryLib;
using Microsoft.AspNetCore.Mvc;

namespace PublisherMass.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class OrderController: ControllerBase
    {
        private readonly IBus _bus;

        public OrderController(IBus bus)
        {
            _bus = bus;
        }

                
        [HttpPost(Name = "GetRequests")]
        public async Task<IActionResult> Post()
        {
            await _bus.Publish(new OrderCreated(1, 2, 3));

            return Ok();
        }

    }
}
