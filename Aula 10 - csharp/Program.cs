using System;

namespace Aula_10___csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(false, "Samsung");
            radio.SwitchOn();
            radio.ListenRadio();
        }
    }
}
