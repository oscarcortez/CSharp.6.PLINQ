using System;
using System.Linq;

namespace ConsoleApp4PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = Enumerable.Range(1, 1000000);

            // Opt in to PLINQ with AsParallel.
            var evenNums = from num in source.AsParallel()
                           where num % 2 == 0
                           select num;
            Console.WriteLine($"{evenNums.Count()} even numbers out of {source.Count()} total");
            // The example displays the following output:
            //       5000 even numbers out of 10000 total


        }
    }
}
