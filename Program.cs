using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] count = new int[25];

            int pop = 0;
            int i;

            for (i = 0; i < count.Length; i++)
            {
                count[i] = pop;
                Console.WriteLine("Element value = " + i + " ");
            }
        }
    }
}
