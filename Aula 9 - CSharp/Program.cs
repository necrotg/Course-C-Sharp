using System;
using System.Collections.Generic;

namespace Aula_9___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            Stack<int> stacks = new Stack<int>();

            for (int i = array.GetLength(0); i > 0; i--) { 
                stacks.Push(i); 
                Console.Write(stacks.Peek()); 
            }
            

        }
    }
}
