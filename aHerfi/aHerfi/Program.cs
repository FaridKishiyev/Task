using System;

namespace aHerfi
{
    class Program
    {
        static void Main(string[] args)
        {
            string soz = Convert.ToString(Console.ReadLine());
            soz = soz.ToLower();
            int count = 0;
            char c;


            foreach (var b in soz)
            {
                c = b;

                if (c=='a')
                {
                    count += 1;
                }
            }

            Console.WriteLine(count);
           
        }
    }
}
