using MassTransit;
using MediarT.Application.Command;
using MediarT.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediarT.Application.Handlers
{
    public class ProcessRequestClientHandler : IRequestHandler<CreateClientRequest, RequestClient>
    {
        private readonly IBus _bus;

        public ProcessRequestClientHandler(IBus bus)
        {
            _bus = bus;
        }
          

        public Task<RequestClient> Handle(CreateClientRequest request, CancellationToken cancellationToken)
        {
            var client = new RequestClient
            {
                Id = new Random().Next(1, 1000),
                IdPerson = request.IdPerson,
                Value = request.Value
            };

            return Task.FromResult(client);

        }
    }
}

