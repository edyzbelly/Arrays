using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LENGTH = 26;
            int[] count = new int[LENGTH];

            int pop = 0;
            int i;

            for (i = 1; i < LENGTH; i++)
            {
                count[i] = pop;
                Console.WriteLine("Element value = " + i);
            }
        }
    }
}
