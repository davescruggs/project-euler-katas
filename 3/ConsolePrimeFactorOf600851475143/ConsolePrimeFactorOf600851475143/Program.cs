using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrimeFactorOf600851475143
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            var sln = PrimeSieve.findLargestPrimeFactor(600851475143);
            sw.Stop();
            Console.Out.WriteLine("Found {0} in {1}", sln, sw.Elapsed);
        }

    }
}
