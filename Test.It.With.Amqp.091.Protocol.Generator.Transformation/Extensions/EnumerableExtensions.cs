using System.Collections.Generic;
using System.Linq;

namespace Test.It.With.Amqp091.Protocol.Generator.Transformation.Extensions
{
    public static class EnumerableExtensions
    {
        internal static IDictionary<int, T> WithIndex<T>(this IEnumerable<T> list)
        {
            return list
                .Select((item, i) =>
                    new { Index = i, Item = item })
                .ToDictionary(
                    arg => arg.Index,
                    arg => arg.Item);
        }
    }
}