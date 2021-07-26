using System;

namespace Aula_6___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixss = { { 1, 2, 3 }, {4, 5, 6 }, { 7, 8, 9 } }; 


            for (int i= 0; i < matrixss.GetLength(0); i++)
            {
                for(int j = 0; j < matrixss.GetLength(0); j++)
                {
                    if (matrixss[i,j] % 2 == 0)
                    {
                        Console.WriteLine("{0} is par",matrixss[i, j]);
                    }
                    else Console.WriteLine("{0} is odd", matrixss[i, j]);
                }
            }
        }
    }
}
