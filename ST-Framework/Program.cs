using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ST_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1000 iterations tests:");
            test(1000);
            Console.WriteLine("\n\n 10000 iterations tests:");
            test(10000);
            Console.WriteLine("\n\n 100 000 iterations tests:");
            test(100000);
            Console.WriteLine("\n\n 1 000 000 iterations tests:");
            test(1000000);
            Console.ReadLine();
        }

        private static void test(int iterations)
        {
            ForTest(iterations);
            GotoTest(iterations);
            ForTest(iterations);
            GotoTest(iterations);
        }

        private static void ForTest(int iterations)
        {
            var test = 0;
            Console.WriteLine("For test:");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start(); //Not using startNew in case it gives an advantage of some sort
            // the code that you want to measure comes here

            for (var i = 0; i < iterations; i++)
            {
                ++test;
            }
            watch.Stop();
            Console.WriteLine($"Elapsed time: {watch.Elapsed}\n");
        }

        private static void GotoTest(int iterations)
        {
            var test = 0;
            Console.WriteLine("GOTO test:");
            var watch = new System.Diagnostics.Stopwatch();
            watch.Reset();
            watch.Start();
            var j = 0;
            Label:
            if (j < iterations)
            {
                ++test;

                j++;
                goto Label;
            }
            watch.Stop();
            Console.WriteLine($"Elapsed time: {watch.Elapsed}\n"); ;
        }
    }
}
