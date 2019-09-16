using System;
using System.Diagnostics;

namespace BenchmarkGuidVsRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            var laps = 10;
            var runs = 500000;
            var sw = Stopwatch.StartNew();

            for (var lap = 0; lap < laps; lap++)
            {
                sw.Restart();
                for (var i = 0; i < runs; i++)
                {
                    Guid.NewGuid();
                }
                Console.WriteLine($"Guid.NewGuid took {sw.ElapsedMilliseconds} ms");
            }

            for (var lap = 0; lap < laps; lap++)
            {
                sw.Restart();
                for (var i = 0; i < runs; i++)
                {
                    new Random().Next(0, 99).ToString("D2");
                }
                Console.WriteLine($"Random.Next took {sw.ElapsedMilliseconds} ms");

            }

            sw.Stop();
            Console.ReadKey();
        }
    }
}
