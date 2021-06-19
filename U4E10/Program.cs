using System;

namespace U4E10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2;
            while (i <= 100)
            {
                if (i % 2 == 0 || i % 3 == 0)
                    Console.WriteLine(i);
                i += 2;
            }

            Console.ReadLine();
        }
    }
}
