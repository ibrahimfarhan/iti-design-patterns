using IteratorPattern.Entities;
using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var series = new FibonacciSeries(10);

            foreach (int i in series)
            {
                Console.WriteLine(i);
            }
        }
    }
}
