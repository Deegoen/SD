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
            Console.WriteLine("Reversed Words:" + " " + ReverseWords(toReverseString));
            Console.WriteLine("Reversed Every Word:" + " " + ReverseEveryWord(toReverseString));
        }
        private static string ReverseString(string toReverseString)
        {
            // Die Maus frisst den Käse --> esäK ned tssirf suaM eiD
            string reversedString = "";

            for (int i = toReverseString.Length - 1; i >= 0; i--)
            {
                reversedString += toReverseString[i];
            }

            return reversedString;
        }

        static string ReverseWords(string toReverseString)
        {
            // Die Maus frisst den Käse --> Käse den frisst Maus Die
            string[] words = toReverseString.Split(' ');
            Array.Reverse(words);
            toReverseString = String.Join(" ", words);
        

            return toReverseString;
        }

        static string ReverseEveryWord(string toReverseString)
        {
            string reversed = "";
            string[] word = toReverseString.Split(' ');
            for (int i = 0; i < word.Length; i++)
            {
                string tempString = word[i];
                char[] tempArray = tempString.ToCharArray();
                Array.Reverse(tempArray);
                toReverseString = String.Join("", tempArray);
                reversed += toReverseString + " ";
            }
            return reversed;
        }
    }
}
