using AirlineBookingSystem.Payments.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.Application.Handler
{
    internal class ProcessConsumerTesterHandler : IRequestHandler<ProcessConsumerTestCommand, Guid>
    {
    }
}
