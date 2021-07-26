using System;

namespace Aula_5___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] migos = { "Rhayssa", "Maicon", "Giovanni", "Priscila", "Anare" };

            foreach(String k in migos)
            {
                Console.WriteLine("Oi piranha: {0}",k);
            }
            Class1 classs = new Class1();
            classs.challenge();
            
        }
    }
}
