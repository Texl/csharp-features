using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp8.Features
{
    public static class AsynchronousStreams
    {
        private static async IAsyncEnumerable<T> Create<T>(int count, int delay, Func<int, T> f)
        {
            for (var i = 0; i < count; ++i)
            {
                await Task.Delay(delay);
                yield return f(i);
            }
        }

        public static async Task<int> Consume()
        {
            IAsyncEnumerable<int> squareStream = Create(2, 100, i => i * i);

            var sumOfSquares = 0;

            await foreach (int square in squareStream)
            {
                sumOfSquares += square;
            }

            return sumOfSquares;
        }
    }
}
