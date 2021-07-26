using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_11___CSharp
{
    class Animals
    {
        protected String name;
        protected int age;
        protected bool isHungry;

        public String GetName()
        {
            return name;
        }
        public void SetName(String name)
        {
            this.name = name;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public bool GetIsHungry()
        {
            return isHungry;
        }
        public void SetIsHungry(bool isHungry)
        {
            this.isHungry = isHungry;
        }

        public Animals()
        {

        }

        public Animals(string name, int age, bool isHungry)
        {
            this.name = name;
            this.age = age;
            this.isHungry = isHungry;
        }

        public virtual void Eat()
        {
            if (isHungry)
            {
                Console.WriteLine($"{name} is eating");
            }
            else Console.WriteLine($"{name} is not hungry");
            
        }
        public virtual void Play()
        {
            Console.WriteLine($"{name} is playing");
        }
        public virtual void MakeSound()
        {
            
        }
    }
}
