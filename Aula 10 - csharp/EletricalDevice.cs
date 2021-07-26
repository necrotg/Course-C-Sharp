using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_10___csharp
{
    class EletricalDevice
    {
        protected bool isOn;
        protected String brand;

        public bool GetIsOn()
        {
            return isOn;
        }
        public void SetIsOn(bool isOn)
        {
            this.isOn = isOn;
        }
        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(String brand)
        {
            this.brand = brand;
        }

        public EletricalDevice()
        {

        }

        public EletricalDevice(bool isOn, String brand)
        {
            this.isOn = isOn;
            this.brand = brand;
        }

        public void SwitchOn()
        {
            isOn = true;
        }
        public void SwitchOff()
        {
            isOn = false;
        }

    }
}
