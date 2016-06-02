using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_problem_03
{
    class mainLargestPrimeFactor
    {
        static void Main(string[] args)
        {
            PrimeGenerator test = new PrimeGenerator();
            List<int> primeTest = test.primeNumberCheck(50);
            foreach (int j in primeTest)
            {
                Console.WriteLine(j);
            }
            Console.ReadKey();
        }
    }
}
