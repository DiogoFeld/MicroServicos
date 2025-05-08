using MassTransit;
using MassTransit.Mediator;
using MediarT.Application.Command;
using MediarT.Core.Entities;
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

        [HttpPost(Name = "SendRequest")]
        public async Task<IActionResult> Post()
        {
            RequestClient request = new RequestClient()
            {
                Value = 1,
                Id = 2,
                IdPerson = 3
            };


            await _bus.Publish(request);

            return Ok();
        }

    }
}
