using System;

namespace L4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = new string[] {"Hallo", "Softwaredesigner"};
            
            for (int i = 0; i < test.Length; i++)
                Console.WriteLine(test[i]);
        }
    }
}
