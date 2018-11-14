using System;

namespace L5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter String:");
            string toReverseString = Console.ReadLine();

            Console.WriteLine("Original String:" + " " + toReverseString);
            Console.WriteLine("Reversed String:" + " " + ReverseString(toReverseString));
            //Console.WriteLine("Reversed Words:" + " " + ReverseWords(toReverseString));
            //Console.WriteLine("Reversed Every Word:" + " " + ReverseEveryWord(toReverseString));
        }
        private static string ReverseString(string toReverseString)
        {
            string reversedString = "";

            for (int i = toReverseString.Length - 1; i >= 0; i--)
            {
                reversedString += toReverseString[i];
            }

            return reversedString;
        }

        private static string ReverseWords(string toReverseString)
        {
            string test = "";

            return test;
        }

        private static string ReverseEveryWord(string toReverseString)
        {
            string test = "";

            return test;
        }
    }
}
