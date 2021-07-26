using System;

namespace Aula__3___Curso_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Pessoa Fabio = new Pessoa("Fabio","Losnak", "Brown", 45);
            Pessoa Elaine = new Pessoa("Elaine", "Ai Zika", "Brown", 45);
            Pessoa Leo = new Pessoa("Leozinho", "Bleiblade", "Brown", 24);
            Pessoa Allan = new Pessoa("Allan", "Cerejinha");
            Fabio.Introcuce();
            Elaine.Introcuce();
            Leo.Introcuce();
            Allan.Introcuce();
            Console.ReadLine();
        }
    }
}
