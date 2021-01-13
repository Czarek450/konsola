using System;

namespace konsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbe l");
            int j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wpisz liczbe K");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wybierz Działanie");
            string g = Console.ReadLine();
            
            if (g == "-")
            {
                Console.WriteLine(j-k);
            }
            else if (g == "+")
            {
                int x = j + k;
                Console.WriteLine(x);
            }
            else if(g == "*")
            {
                Console.WriteLine(j*k);
            }

            Console.ReadKey();
        }
    }
}
