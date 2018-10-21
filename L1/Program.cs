using System;

namespace L01
{
    class Program
    {
        static void Main(string[] args)
        {
            int argsAsInt = Int32.Parse(args[0]);
               Console.WriteLine(RomanConversion.GetRomanNumber(argsAsInt));
               
           }

        }
    }
