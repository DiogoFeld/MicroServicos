using MassTransit;
using MediarT.Application.Command;
using MediarT.Core.Entities;
using MediatR;

namespace MediarT.Application.Consumer
{
    public class RequestClientConsumer : IConsumer<RequestClient>
    {
        private readonly IMediator _mediator;

        public RequestClientConsumer(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task Consume(ConsumeContext<RequestClient> context)
        {
            var personRequest = context.Message;


            CreateClientRequest request = new CreateClientRequest()
            {
                IdPerson = personRequest.IdPerson,
                Value = personRequest.Value
            };



            await _mediator.Send(request);
        }
    }
}
