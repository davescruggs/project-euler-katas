using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrimeFactorOf600851475143
{
    
    public class PrimeSieve
    {
        long lastPrimeFactor = 1;



        public static long findLargestPrimeFactor(long targetMultiple)
        {
            List<long> primes = new List<long>();
            Stack<long> primeFactors = new Stack<long>();

            long sqrt = Convert.ToInt64(Math.Ceiling(Math.Sqrt(targetMultiple)));

            //seed list of numbers
            for (long i = 2; i <= sqrt; i++)
            {
                if (validatePrime(primes, i))
                {
                    primes.Add(i);
                    if (targetMultiple % i == 0)
                    {
                        primeFactors.Push(i);
                    }
                }
            }

            return primeFactors.First<long>(); //counter-intuitive. Last prime is on top
        }

        private static bool validatePrime(List<long> primes, long i)
        {
            if (i == 2) return true; // bootstrapping the prime sequence
            var primeEnumerator = primes.GetEnumerator();
            while (primeEnumerator.MoveNext())
            {
                long current = primeEnumerator.Current;
                if (i % current == 0) return false;
            }
            return true;
        }



    }
}
