using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___csharp
{
    class Radio : EletricalDevice
    {
        public Radio(bool isOn, string brand):base(isOn,brand)
        {
            
        }

        public void ListenRadio()
        {
            if (isOn)
            {
                Console.WriteLine("You are listening to the radio");
            }
            else Console.WriteLine("Radio is turned off");
        }
    }
}
