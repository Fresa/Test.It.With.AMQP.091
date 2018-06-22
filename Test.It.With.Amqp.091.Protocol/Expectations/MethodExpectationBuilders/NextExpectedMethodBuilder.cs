using System;
using System.Collections.Generic;
using Test.It.With.Amqp.Protocol;

namespace Test.It.With.Amqp091.Protocol.Expectations.MethodExpectationBuilders
{
    internal class NextExpectedMethodBuilder : ExpectedMethodBuilder
    {
        private readonly MethodExpectationBuilder _builder;

        public NextExpectedMethodBuilder(MethodExpectationBuilder builder)
        {
            _builder = builder;
        }

        private readonly List<Type> _methods = new List<Type>();

        public OrMethodExpectedBuilder Then<TClient>() where TClient : IClientMethod
        {
            _methods.Add(typeof(TClient));
            return new OrMethodExpectedBuilder(_builder, _methods);
        }

        public OrMethodExpectedBuilder ThenProtocolHeader()
        {
            _methods.Add(typeof(ProtocolHeader));
            return new OrMethodExpectedBuilder(_builder, _methods);
        }

        public override Type[] Types => _methods.ToArray();
    }
}