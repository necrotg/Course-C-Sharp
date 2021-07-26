using System;

namespace Aula_4___Curso_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3,3,3);
            Console.WriteLine("Volume {0} and the Front Surface is {1}",box.GetVolume(),box.GetFrontSurface());

        }
    }
}
