using System;
using System.Collections.Generic;
using System.Linq;

namespace SRN.Euler.Core
{
   public class PrimeHelper
   {
      private List<int> _primes;
      public PrimeHelper()
      {
         _primes = new List<int> {2};
      }

      /// <summary>
      /// Gets a brute force nth prime number without pre-calculating primes
      /// </summary>
      /// <param name="nthPrime"></param>
      /// <returns></returns>
      public int GetNthPrime(uint nthPrime)
      {
         int target = _primes.Last();
         while (_primes.Count < nthPrime)
         {
            target++;
            if (IsPrime(target))
            {
               _primes.Add(target);
            }
         }

         return _primes[(int)nthPrime - 1];
      }

      private static bool IsPrime(int number)
      {
         if (number <= 1) return false;
         if (number == 2) return true;
         if (number % 2 == 0) return false;

         int boundary = (int)Math.Floor(Math.Sqrt(number));

         for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
               return false;

         return true;
      }
   }
}

