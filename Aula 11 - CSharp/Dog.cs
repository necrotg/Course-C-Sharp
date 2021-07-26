using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11___CSharp
{
    class Dog : Animals
    {
        protected bool isHappy;
        public Dog(string name, int age, bool isHungry) : base(name, age, isHungry)
        {
            isHappy = true;
        }

        public bool GetIsHappy()
        {
            return isHappy;
        }
        public void SetIsHappy(bool isHappy)
        {
            this.isHappy = isHappy;
        }
        public override void Eat()
        {
            base.Eat();
        }
        public override void MakeSound()
        {
            Console.WriteLine("auuuuuuuuuu!!");
        }
        public override void Play()
        {
            if (isHappy)
            {
                base.Play();
            }
            
        }
    }
}
