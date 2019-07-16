using System;
using System.Collections.Generic;
using System.Linq;

namespace SRN.Euler.Core
{
   public class PrimeSieveEratosthenes
   {
      private readonly List<int> _primes;
      public PrimeSieveEratosthenes(uint maxPrimeNumber)
      {
         var sieve = BuildSieve(Math.Max((int)maxPrimeNumber, 10));

         _primes = sieve.Select((s, i) => new {i, s})
            .Where(t => t.s)
            .Select(t => t.i)
            .ToList();
      }

      public int GetNthPrime(uint nthPrime)
      {
         return _primes[(int)nthPrime - 1];
      }

      private bool[] BuildSieve(int max)
      {
         // array to hold the values
         var sieveArray = new bool[max + 1];
         // init the array to all true ig greater than 2 (0 and 1 and not prime)
         for (int i = 2; i <= max; i++) sieveArray[i] = true;

         // The sieve loops through each value and marks out multiples of the value if it is prime
         for (int targetNumber = 2; targetNumber <= max; targetNumber++)
         {
            // if the number is prime, cross out multiples of it
            if (sieveArray[targetNumber])
            {
               for (int multiple = targetNumber * 2; multiple <= max; multiple += targetNumber)
                  sieveArray[multiple] = false;
            }
         }
         return sieveArray;
      }
   }
}
