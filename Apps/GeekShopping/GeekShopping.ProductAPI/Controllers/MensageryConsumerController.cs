
using GeekShopping.ProductAPI.Models.Requests;
using GeekShopping.ProductAPI.RabbitMqConsumer;
using GeekShopping.ProductAPI.RabbitMQSender;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MensageryConsumerController : ControllerBase
    {
        IRabbitMQConsumer _IRabbitMQCheckoutConsumer;

        public MensageryConsumerController(IRabbitMQConsumer iRabbitMQCheckoutConsumer)
        {
            _IRabbitMQCheckoutConsumer = iRabbitMQCheckoutConsumer ?? throw new ArgumentNullException(nameof(iRabbitMQCheckoutConsumer));
        }

        [HttpPost(Name = "GetRequests")]
        public bool sendMensageryRequest(string queuName)
        {
            //get consumer 
            _IRabbitMQCheckoutConsumer.GetMessage(queuName);

            //use rabbit then
            // then consyume rabbit stack and do stuff
            return true;
        }

    }
}
