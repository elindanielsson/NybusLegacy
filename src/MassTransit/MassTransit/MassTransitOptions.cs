﻿using Nybus.Configuration;

namespace Nybus.MassTransit
{
    public class MassTransitOptions
    {
        public IQueueStrategy CommandQueueStrategy { get; set; } = new AutoGeneratedNameQueueStrategy();

        public IErrorStrategy CommandErrorStrategy { get; set; } = new RetryErrorStrategy(5);

        public IQueueStrategy EventQueueStrategy { get; set; } = new TemporaryQueueStrategy();

        public IErrorStrategy EventErrorStrategy { get; set; } = new RetryErrorStrategy(5);

        public IServiceBusFactory ServiceBusFactory { get; set; } = new DefaultServiceBusFactory();

        public ILogger Logger { get; set; } = new NopLogger();
    }
}