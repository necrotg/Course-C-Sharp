using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula__3___Curso_CSharp
{
    class Pessoa
    {
        private string firstName, lastName, eyeColor;
        private int age;

        public Pessoa(){
        }
        public Pessoa(string firstName)
        {
            this.firstName = firstName;
        }
        public Pessoa(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Pessoa(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }
        public Pessoa(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }
        
        public void Introcuce() 
        {
            if (age != 0 ){
                Console.WriteLine("My name is {0} {1}, my eyes are {2}", firstName, lastName, eyeColor);
                 
            }else if (eyeColor==null)
            {
                Console.WriteLine("My name is {0} {1}", firstName, lastName);
            }else if  (lastName==null)
            {
                Console.WriteLine("My name is {0}", firstName);
            }else Console.WriteLine("My name is {0} {1}, my eyes are {2}" +
                " and i am {3} years old", firstName, lastName, eyeColor, age);
        }
    }
}
