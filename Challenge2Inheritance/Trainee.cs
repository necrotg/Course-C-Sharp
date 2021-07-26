using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Inheritance
{
    class Trainee : Employee
    {
        protected double workingHours;
        protected double schoolHours;

        public double GetWorkingHours()
        {
            return workingHours;
        }
        public double GetSchoolHours()
        {
            return schoolHours;
        }
        public Trainee(){
        }
        public Trainee(string name, string fisrtName, double salary, double workingHours, double schoolHours) : base(name, fisrtName, salary)
        {
            this.workingHours = workingHours;
            this.schoolHours = schoolHours;
        }
        public void Learn()
        {
            Console.WriteLine("learning");
        }
        public override void Work()
        {
            
        }
    }
}
