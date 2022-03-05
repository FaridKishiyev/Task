using System;

namespace _3ebolme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 8, 11, 9, 25, 33, 150, 78, 93, 55, 28, 83 };
            int b = 0;

            for (int i = 0; i < num.Length ; i++)
            {             
                if (num[i] % 3 == 0)
                {
                    b= b+num[i];
                }
            }
            Console.WriteLine(b);
        }
    }
}
