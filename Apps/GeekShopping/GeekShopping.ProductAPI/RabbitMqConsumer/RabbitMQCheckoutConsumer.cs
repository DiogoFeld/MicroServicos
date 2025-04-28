using GeekShopping.MessageBus;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;

namespace GeekShopping.ProductAPI.RabbitMqConsumer
{
    public class RabbitMQConsumer: IRabbitMQConsumer
    {


        private readonly string _hostName;
        private readonly string _password;
        private readonly string _userName;
        private IConnection _connection;
        private IModel _channel;

        public RabbitMQConsumer()
        {
            _hostName = "localhost";
            _password = "guest";
            _userName = "guest";
        }


        public void GetMessage(string queueName)
        {
            var factory = new ConnectionFactory
            {
                HostName = _hostName,
                UserName = _password,
                Password = _userName,
                Port = 5672
            };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();

            _channel.QueueDeclare(queue: queueName,
                         durable: false,
                         exclusive: false,
                         autoDelete: false,
                         arguments: null);


            var consumer = new EventingBasicConsumer(_channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine($" [x] Mensagem recebida: {message}");
                
                BaseMessage objectMessage = JsonSerializer.Deserialize<BaseMessage>(message);
            };

            // Consumir mensagens da fila
            _channel.BasicConsume(queue: queueName,
                                 autoAck: true,
                                 consumer: consumer);

        }



    }
}
