using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] luckyNumbers = {4, 8, 15, 16, 23, 42};
            // originally this would print 8
            luckyNumbers[1] = 900;
            // now it prints 900
            Console.WriteLine(luckyNumbers[1] );
            Console.ReadLine();

            // array of strings
            string[] friends = new string[3];
            //number in new string tells c# how many elements the array can hold
            // can hold 3 values
            friends[0] ="Jim";
            friends[1] ="Kelly";
        }
    }
}
