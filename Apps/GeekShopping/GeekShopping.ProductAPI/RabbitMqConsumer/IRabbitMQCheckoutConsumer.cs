using GeekShopping.MessageBus;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;

namespace GeekShopping.ProductAPI.RabbitMqConsumer
{
    public interface IRabbitMQConsumer
    {
        void GetMessage(string queueName);
    }
}
