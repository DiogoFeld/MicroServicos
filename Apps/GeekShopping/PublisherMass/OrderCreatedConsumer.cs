using MassTransit;
using MensageryLib;
using System.Collections.Concurrent;

namespace PublisherMass
{
    public class OrderCreatedConsumer : IConsumer<OrderCreated>
    {
        public OrderCreatedConsumer(){ }

        public Task Consume(ConsumeContext<OrderCreated> context)
        {
            Console.WriteLine("consuming");

            return Task.CompletedTask;
        }
    }
}
