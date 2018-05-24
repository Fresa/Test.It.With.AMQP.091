using Test.It.With.Amqp.Protocol;
using Test.It.With.Amqp.Protocol.Expectations;

using Test.It.With.Amqp091.Protocol.Generator;

namespace Test.It.With.Amqp091.Protocol
{
    internal class Amqp091ProtocolResolver : IProtocolResolver
    {
        private Amqp091ProtocolResolver()
        {
            Protocol = new Amq091Protocol();
            ExpectationStateMachineFactory = new Amqp091ExpectationStateMachineFactory();
            AmqpReaderFactory = new Amqp091ReaderFactory();
            AmqpWriterFactory = new Amqp091WriterFactory();
            FrameFactory = new Amqp091FrameFactory(AmqpWriterFactory);
        }

        public static IProtocolResolver Create()
        {
            return new Amqp091ProtocolResolver();
        }

        public IProtocol Protocol { get; }

        public IExpectationStateMachineFactory ExpectationStateMachineFactory { get; }

        public IFrameFactory FrameFactory { get; }

        public IAmqpReaderFactory AmqpReaderFactory { get; }

        public IAmqpWriterFactory AmqpWriterFactory { get; }
    }
}
