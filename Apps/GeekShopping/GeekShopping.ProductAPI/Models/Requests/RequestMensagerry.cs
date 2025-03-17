namespace GeekShopping.ProductAPI.Models.Requests
{
    public class RequestMensagerry
    {
        public int id { get; set; }
        public int value { get; set; }
        public int idProcess { get; set; }
        public int name { get; set; }
        public int quantitySelected { get; set; }
        public List<int> itens { get; set; }

    }
}
