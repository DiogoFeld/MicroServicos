using GeekShopping.ProductAPI.Models.Requests;
using GeekShopping.ProductAPI.RabbitMQSender;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MensageryRequesterController : ControllerBase
    {

        private IRabbitMQMessageSender _rabbitMQMessageSender;

        public MensageryRequesterController(IRabbitMQMessageSender rabbitMQMessageSender)
        {
            _rabbitMQMessageSender = rabbitMQMessageSender
                ?? throw new ArgumentNullException(nameof(rabbitMQMessageSender));
        }

        [HttpPost(Name ="SendRequest")]
        public bool sendMensageryRequest(RequestMensagerry requestMensagerryModel)
        {
            RequestMensagerryVO request = new RequestMensagerryVO(requestMensagerryModel);
            _rabbitMQMessageSender.SendMessage(request, "requestForMenssagery");




            return true;
        }
        //implement mensagery client
    }
}
