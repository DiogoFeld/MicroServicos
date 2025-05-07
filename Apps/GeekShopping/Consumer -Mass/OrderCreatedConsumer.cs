using MassTransit;
using MensageryLib;

namespace Consumer__Mass
{
    public class OrderCreatedConsumer : IConsumer<OrderCreated>
    {
        public Task Consume(ConsumeContext<OrderCreated> context)
        {
            var objectResult = context.Message;

            throw new NotImplementedException();
        }
    }
}