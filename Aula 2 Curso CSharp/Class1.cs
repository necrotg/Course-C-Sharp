using System;

namespace Aula_2_Curso_CSharp
{
    class Aula2 {

        const double pi = 3.1415;
        const int months = 12, weeks = 52;
        const string birthday = "15/03/2000";
        static string player, top = "crimson";
        static long highscore = 90000;
        static long score;
        static int temp = 0;

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Blue;

            Challengeloop();
            Forloop();
            ChallengeTemp();
            EnhancedIf();
            ChallengeScore();
            SwitchvsIf();
            LoginSystem();
            Conditions();
            TryCatch2();
            TryCatch();
            Challenge2();
            ConvertDataTypes();
            ReturnASC();
            String();
            TryCatch();
        }

       public static void ReturnASC()
        {
            print("Entre uma letra: ");

            int letra = Console.Read();

            Console.WriteLine(letra);
        }
        public static void String()
        {
            String myname = "Felipe";

            string capname = myname.ToUpper();
            print("My name is " + capname);

            print("Entre com algum valor");
            string valor = Console.ReadLine();
            print(valor);
        }
        public static void ConvertDataTypes()
        {
            double numdouble = 7.42;
            int numint = (int)numdouble;
            String numstring = numdouble.ToString();
            Console.WriteLine(numint);

            string num = "15";
            int num1 = Int32.Parse(num);
        }
        public static void Challenge1()
        {
            String nome;
            print("Please enter your name and press enter: ");
            nome = Console.ReadLine();
            print(nome.ToUpper());
            print(nome.ToLower());
            print(nome.Trim());
            print(nome.Substring(2));
        }
        public static void Challenge2()
        {
            String search, str;
            print("Enter a String here: ");
            str = Console.ReadLine();
            print("Enter a Character to search: ");
            search = Console.ReadLine();

            Console.WriteLine(str.IndexOf(search));

            print("Enter first name ");
            String firstname = Console.ReadLine();
            print("Enter last name ");
            String lastname = Console.ReadLine();
            print(firstname + " " + lastname);
        }
        public static void print(String text)
        {
            Console.WriteLine(text);
        }
        public static void TryCatch()
        {
            
                print("Enter a number:");
                string num1 = Console.ReadLine();
            try
            {
                int num2 = int.Parse(num1);

            }
            catch (FormatException){
                print("Formato inválido");
            }
            catch (OverflowException)
            {
                print("Numero pequeno ou grande");
            }
            catch (ArgumentNullException)
            {
                print("Valor vazio");
            }

        }
        public static void TryCatch2()
        {
            int num1 = 4, num2 = 0;
            try
            {
                double div = num1 / num2;
            }catch (DivideByZeroException)
            {
                Console.WriteLine("Númeor não pode ser dividido por zero");
            }
        }
        public static void Conditions()
        {
            int tempint, numero;
            print("Set a Temperature");
            String temp = Console.ReadLine();
            if (int.TryParse(temp, out numero))
            {
                tempint = numero;
            }
            else
            {
                tempint = 0;
            }

            if (tempint < 20)
            {
                print("Take the coat");
            } else if (tempint == 20)
            {
                print("Nice temperature");
            }else if (tempint > 20)
            {
                print(" go outside nacked");
            }
        }
        public static void LoginSystem()
        {
            
                print("Digite um usuario");
                String usuario = Console.ReadLine();
                print("Digite uma senha");
                String senha = Console.ReadLine();
                print("you are registered");
                print("Digite o usuario");
                String usuario2 = Console.ReadLine();
                print("Digite a senha");
                String senha2 = Console.ReadLine();
            if (usuario.Equals(usuario2) && senha.Equals(senha2)){
                print("you are logged in");
            }
            else
            {
                print("errou otario");
            }
        }
        public static void SwitchvsIf()
        {
            int age = 19;

            if (age == 15) {
                print("Too young");
            } else if (age == 25) {
                print("They have proper age");
            }
            else
            {
                print("qual a idade?");
            }

        }
        public static void ChallengeScore()
        {
            print("Enter your user name");
            String player = Console.ReadLine();
            print("Enter your score");
            String scorestr = Console.ReadLine();

            score = long.Parse(scorestr);

            CaucScore(player, score);
        }
        public static void CaucScore(String player, long score)
        {
            if (score > highscore)
            {
                highscore = score;
                top = player;
                Console.WriteLine("New high score is {0} and the new holder is {1}", score, player);
                
            }else
            {
                print("The high score and the holder still the same " + highscore + " " + top);
            }
        }
        public static void EnhancedIf()
        {
            int temp = -3;
            String state = temp < 0 ? "solid" : temp > 100 ? "gas" : "liquid";
            Console.WriteLine(state);
        }
        public static void ChallengeTemp()
        {
            Console.WriteLine("Set a temperature");
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                String outs = temp <= 15 ? "too cold" : temp >= 16 && temp <= 28 ? "ok" : "hot";
                Console.WriteLine(outs);
            }
            else
                Console.WriteLine("Temperatura inválida");
        }
        public static void Forloop()
        {
            for(int cont = 0; cont <= 20; cont++)
            {
                Console.WriteLine(cont);
            } 
        }
        public static void Challengeloop()
        {
            int final;
            double nota1 = 0, nota;
            Console.WriteLine("Digite a quantidade de Alunos: ");
            String qtd = Console.ReadLine();
            final = int.Parse(qtd);
            for (int alunos = 1;alunos != final+1; alunos++)
            {
                Console.WriteLine("Adicione a nota do aluno {0}", alunos);
                String notastr = Console.ReadLine();
                if (double.TryParse(notastr, out nota1)){
                    nota = nota1;
                }else
                    Console.WriteLine("Invalido");
                nota = nota1;


                if (nota > 20 || nota < -1){
                    Console.WriteLine("Valor imcompativel");
                    break;
                }
                if (nota == -1)
                {
                    Console.WriteLine("Saindo");
                    break;
                }
                nota1 += nota;
            }
            double media = nota1 / final;
            Console.WriteLine("Media de todas as notas eh: {0}",media);
        }
    }
    
    

}
