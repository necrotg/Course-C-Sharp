using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Inheritance
{
    class Employee
    {
        protected String name;
        protected String firstName;
        protected Double salary;

        public String GetName()
        {
            return name;
        }
        public String GetFirstName()
        {
            return firstName;
        }
        public double GetSalary()
        {
            return salary;
        }

        public Employee()
        {

        }

        public Employee(string name, string fisrtName, double salary)
        {
            this.name = name;
            this.firstName = fisrtName;
            this.salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{name} is working");
        }
        public void Pause()
        {
            Console.WriteLine($"{name} stopped working");
        }
    }
}
