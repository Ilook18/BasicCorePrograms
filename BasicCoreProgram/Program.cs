using System;

namespace BasicCoreProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the Program number which is to be executed \n 1. Flip Coin \n 2. Leap Year \n 3. Power of Two \n 4. Harmonic Number \n 5. Factors \n 6. Quotient Remainder \n 7. SwapTwoNumers \n 8. Even Or Odd Number \n 9. Vowel or Consonent \n 10.Largest Number \n 11.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin coin = new FlipCoin();
                        coin.Play();
                        break;
                    case 2:
                        LeapYear check = new LeapYear();
                        check.Leap();
                        break;
                    case 3:
                        PowerOfTwo res = new PowerOfTwo();
                        res.Power();
                        break;
                    case 4:
                        HarmonicNumber sum = new HarmonicNumber();
                        sum.Harmonic();
                        break;
                    case 5:
                        PrimeFactorization pf = new PrimeFactorization();
                        pf.primeFactors();
                        break;
                    case 6:
                        QuotientRemainder result = new QuotientRemainder();
                        result.Division();
                        break;
                    case 7:
                        Swapping nos = new Swapping();
                        nos.Swapp();
                        break;
                    case 8:
                        OddEven num = new OddEven();
                        num.EvenOdd();
                        break;
                    case 9:
                        VowelOrConsonant letter = new VowelOrConsonant();
                        letter.VowelConsonant();
                        break;
                    case 10:
                        LargestNumber max = new LargestNumber();
                        max.Largest();
                        break;
                    case 11:
                        flag = false;
                        break;
                }
            }
        }
    }
}