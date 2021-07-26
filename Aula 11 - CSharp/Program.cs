using System;

namespace Aula_11___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Jubileu", 6, true);
            Console.WriteLine($"{dog.GetName()} is {dog.GetAge()} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();
        }
    }
}
