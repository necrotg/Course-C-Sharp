using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15___CSharp
{
    class Audi : Car
    {
        public Audi()
        {
        }

        public Audi(int hp, string color, String model, String brandaudi) : base(hp, color)
        {
            this.model = model;
            this.brandaudi = brandaudi;
        }

        protected String model { get; set; }
        protected String brandaudi { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"The car has {hp} horse power and it's color is {color} the model is {model} and the brand is {brandaudi}");
        }
        public override void Repair()
        {
            Console.WriteLine("Audi was repaired");
        }

    }
}
