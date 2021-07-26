using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_5___CSharp
{
    class Class1
    {
        public void challenge()
        {
            Console.WriteLine("Enter any value");
            String value = Console.ReadLine();
            Console.WriteLine("Qual o tipo do valor colocado?\n1 - String\n2 - int\n3 - Boolean");
            String type = Console.ReadLine();

            switch (type)
            { 
                case "1": if (isalfa(value))
                    {
                        Console.WriteLine("Valor é String");
                    }
                    else Console.WriteLine("Valor nao é String");

                    break;
                case "2": 
                    if (int.TryParse(value,out int number )){
                        Console.WriteLine("Valor colocado é int");
                    }
                    else Console.WriteLine("Valor colocado não é int");
                    break;
                case "3":
                    if (Boolean.TryParse(value, out Boolean numberbool))
                    {
                        Console.WriteLine("Valor colocado é bool");
                    }
                    else Console.WriteLine("Valor colocado não é bool");
                    break;
                    

            }
            static bool isalfa(String value)
            {
                foreach(char c in value)
                {
                  if (!char.IsLetter(c)){
                        return false;
                  }
                    
                }
                return true;
            }
        }
    }
}
