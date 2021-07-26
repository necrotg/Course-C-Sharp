using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15___CSharp
{
    class BMW:Car
    {
        public BMW()
        {
        }

        public BMW(int hp, string color, String model, String brandbmw) : base(hp, color)
        {
            this.model = model;
            this.brandbmw = brandbmw;
        }

        protected String model { get; set; }
        protected String brandbmw { get; set; }

        public override void ShowDetails()
        {
            Console.WriteLine($"The car has {hp} horse power and it's color is {color} the model is {model} and the brand is {brandbmw}");
        }
        public override void Repair()
        {
            Console.WriteLine("The BMW was repaired");
        }

    }
}
