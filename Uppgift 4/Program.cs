using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många poäng fick du? : ");
            int poäng = Convert.ToInt32(Console.ReadLine());

            if (poäng >= 55)
            {
                Console.WriteLine("Du fick ett A");
            }

            else if (poäng >= 46 && poäng < 55)
            {
                Console.WriteLine("Du fick ett B");
            }


            else if (poäng >= 35 && poäng < 46)
            {
                Console.WriteLine("Du fick ett C");
            }

            else if (poäng >= 27 && poäng < 35)
            {
                Console.WriteLine("Du fick ett D");
            }

            else if (poäng >= 18 && poäng < 27)
            {
                Console.WriteLine("Du fick ett E");
            }

            else
            {
                Console.WriteLine("Du fick ett F");
            }

        }
    }
}
