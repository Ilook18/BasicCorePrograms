using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
   public  class PrimeFactorization
    {
         public void primeFactors()
        {

            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                n = n / 2;
            }

            for(int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n = n / i;
                }
            }

            if (n > 2)
            {
                Console.WriteLine(n);
            }
        }

    }
}
