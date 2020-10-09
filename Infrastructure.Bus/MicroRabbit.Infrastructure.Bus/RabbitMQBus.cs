using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using MicroRabbit.Domain.Core;
using MicroRabbit.Domain.Core.Bus;

namespace MicroRabbit.Infrastructure.Bus
{
    public class RabbitMQBus : IEventBus
    {
        private readonly IMediator _mediator;
        private readonly Dictionary<string, List<Type>> _handlers;
        private readonly List<Type> _eventTypes;

        public RabbitMQBus(IMediator mediator)
        {
            _mediator = mediator;
            _handlers = new Dictionary<string, List<Type>>();
            _eventTypes = new List<Type>();
        }

        void IEventBus.Publish<T>(T @event)
        {
            throw new System.NotImplementedException();
        }

        Task IEventBus.SendCommand<T>(T command)
        {
            return _mediator.Send(command);
        }

        void IEventBus.Subscribe<T, THandler>()
        {
            throw new System.NotImplementedException();
        }
    }
}