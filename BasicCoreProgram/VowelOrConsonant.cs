using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class VowelOrConsonant
    {
        public void VowelConsonant ()
        {
            Console.WriteLine("Enter an Alphabet :");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("{0} is a vowel", letter);
            }
            else
            {
                Console.WriteLine("{0} is a Consonant", letter);
            }
        }
    }
}