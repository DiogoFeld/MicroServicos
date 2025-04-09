
using GeekShopping.ProductAPI.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.ProductAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MensageryConsumerController : ControllerBase
    {
        [HttpPost(Name = "GetRequests")]
        public bool sendMensageryRequest(string queuName)
        {
            //get consumer 


            //use rabbit then
            // then consyume rabbit stack and do stuff
            return true;
        }

    }
}
