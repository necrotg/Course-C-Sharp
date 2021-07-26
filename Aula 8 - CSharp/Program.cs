using System;

namespace Aula_8___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] happiness = { 1, 2, 3, 4, 5 };
            increase(happiness);
            foreach(int value in happiness)
            {
                Console.WriteLine(value);
            }
        }
        static void increase(int[] happiness)
        {
            for(int i = 0; i < happiness.Length; i++)
            {
                happiness[i] += 2;
            }
        }
    }
}
