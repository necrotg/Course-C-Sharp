using System;

namespace Challenge2Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Fernando Lima","Fernando",2000);
            Trainee tra = new Trainee("Lucas", "Lucas Abaca", 200, 30, 40);
            Boss boss1 = new Boss("Ciro", "Ciro Tasso", 10000, "Honda");
        }
    }
}
