using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15___CSharp
{
    class Car
    {
        protected int hp { get; set; }
        protected String color { get; set; }

        public Car()
        {

        }
        public Car(int hp, string color)
        {
            this.hp = hp;
            this.color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"The car has {hp} horse power and it's color is {color}");
        }
        public virtual void Repair()
        {
            Console.WriteLine("Car was repaired");
        }

        


    }
}
