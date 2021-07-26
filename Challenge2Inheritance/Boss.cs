using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Inheritance
{
    class Boss:Employee
    {
        protected String companyCar;

        public String GetCompanyCar()
        {
            return companyCar;
        }
        public Boss()
        {

        }
        public Boss(string name, string fisrtName, double salary, String companyCar) : base(name, fisrtName, salary)
        {
            this.companyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Leading");
        }
    }
}
