using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingTestabilityStepByStep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text:");
            var text = Console.ReadLine();
            var words = text.Split(' ');
            var n = words.Length;
            Console.WriteLine($"Number of words: {n}");

            Console.ReadKey();
        }
    }
}
