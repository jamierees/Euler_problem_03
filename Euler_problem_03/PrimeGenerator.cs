using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_problem_03
{
    class PrimeGenerator
    {
        

        public List<int> primeNumberCheck(int numberOfPrimes)
        {
            List<int> prime = new List<int>{ 2, 3, 5, 7, 11, 13, 17 };
            int count = prime.Last() + 1;
            int primeVariable = prime.Last();
            while (count < numberOfPrimes + 1)
            {
                if (checkMultiple(count) == true && checkSquareRoot(prime, count) == true)
                {
                    prime.Add(count);
                }

                count++;
            }
            return prime;
        }

        static public bool checkMultiple(int possiblePrime)
        {
            return ((possiblePrime % 2 != 0) && (possiblePrime % 3 != 0) && (possiblePrime % 5 != 0));
        }

        static private bool checkSquareRoot(List<int> primeList, int possiblePrime)
        {
            bool isPrime = true;
            double squareNumber = Math.Sqrt(possiblePrime);
            int j = 0;
            while (squareNumber >= primeList[j])
            {
                if (possiblePrime%primeList[j] == 0)
                {
                    isPrime = false;
                }
                j++;
            }
            return isPrime;
              
        }
    }
}
