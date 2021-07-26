using System;
using System.Collections;
using System.Collections.Generic;

namespace Aula_15___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car> {
                new BMW(20, "Black", "tesla", "IDK")
            };
           
            foreach(var car in cars)
            {
                car.ShowDetails();
                car.Repair();
            }
        }
    }
}
