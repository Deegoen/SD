using System;
using System.Drawing;


namespace Formattierung
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Adam", "Bridgette", "Carla", "Daniel",
                         "Ebenezer", "Francine", "George" };
            string[] nachname = { "Huber", "Müller", "Degen", "Schnee",
                         "Peters", "Maier", "Kalisch" };
            decimal[] hours = { 40, 6, 44, 82, 40, 80,
                                 16 };

            //Console.WriteLine("Test", Console.ForegroundColor = ConsoleColor.Red);


            
            Console.WriteLine("{0,-20} {1, -20} {2,5}\n", "Name", "Nachname", "Hours");
            

            for (int ctr = 0; ctr < names.Length; ctr++)
                Console.WriteLine("{0,-20} {1,-20} {2,5:N1}", names[ctr], nachname[ctr], hours[ctr]);

        }
    }
}