using MediarT.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediarT.Application.Command
{
    public class CreateClientRequest : IRequest<RequestClient>
    {
        public int IdPerson { get; set; }
        public int Value { get; set; }
    }
}
