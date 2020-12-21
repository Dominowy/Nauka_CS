using System;

namespace N._3
{
    class Program
    {
        static void Main()
        {
            Program2 p1 = new Program2();

            for (int i = 0; i < 2; i++)
            {
                p1.y[i] = 1+i;
            }
            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(p1.y[i]);
            }

        }
    }
}