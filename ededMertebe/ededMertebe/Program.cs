using System;

namespace ededMertebe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ədəd daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            while (a > 0)
            {
                a = a / 10;
                b += 1;
            }

            Console.WriteLine(b);
        }
    }
}
