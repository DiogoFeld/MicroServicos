using GeekShopping.MessageBus;

namespace GeekShopping.ProductAPI.Models.Requests
{
    public class RequestMensagerryVO : BaseMessage
    {
        public RequestMensagerryVO(RequestMensagerry requestMensagerryModel)
        {
            this.value = requestMensagerryModel.value;
            this.id = requestMensagerryModel.id;
            this.idProcess = requestMensagerryModel.idProcess;
            this.name = requestMensagerryModel.name;
            this.itens = requestMensagerryModel.itens;
            this.quantitySelected = requestMensagerryModel.quantitySelected;
        }

        public int id { get; set; }
        public int value { get; set; }
        public int idProcess { get; set; }
        public int name { get; set; }
        public int quantitySelected { get; set; }
        public List<int> itens { get; set; }

    }
}
