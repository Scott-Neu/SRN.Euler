﻿using System;
using SRN.Euler.Core;
using Xunit;

namespace SRN.Euler.Test
{
   public class PrimeSieveEratosthenesTests
   {
      [Theory]
      [InlineData(1, 2)]
      [InlineData(6, 13)]
      [InlineData(20, 71)]
      [InlineData(181, 1087)]
      [InlineData(500, 3571)]
      [InlineData(1000, 7919)]
      [InlineData(1000001, 15485867)]
      public void GetNthPrime(uint nthPrime, uint target)
      {
         var sieve = new PrimeSieveEratosthenes(nthPrime * nthPrime);

         var result = sieve.GetNthPrime(nthPrime);

         Assert.True(result == target);
      }

      [Fact]
      public void Get10001stPrime()
      {
         var sieve = new PrimeSieveEratosthenes(10001 * 10001);

         var result = sieve.GetNthPrime(10001);

         Assert.True(result == 104743);
      }
   }
}
