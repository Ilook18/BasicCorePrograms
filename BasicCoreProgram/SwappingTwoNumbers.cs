using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCoreProgram
{
    public class Swapping
    {
        public void Swapp()
        {
            Console.WriteLine("Enter the First number :");
            int First_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number :");
            int Second_Number = Convert.ToInt32(Console.ReadLine());
            First_Number = First_Number + Second_Number;
            Second_Number = First_Number - Second_Number;
            First_Number = First_Number - Second_Number;
            Console.WriteLine("After Swapping these Two Numbers : First number is =" + First_Number + " and Second number is =" + Second_Number);
        }
    }
}