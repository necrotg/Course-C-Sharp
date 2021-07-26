using System;

namespace ula_16___CSharp
{
    class Program
    {
        public delegate double multiply(double num1, double num2);
        static void Main(string[] args)
        {
            
            multiply mult = (num1, num2) => num1 * num2;
            Display(mult);
            Console.WriteLine("Hello World!");
        }
        static void Display(multiply result)
        {
            Console.WriteLine(result(2,4));
        }
    }
}
