using System;

namespace Calculadora{

    class Program{

        static void Main(string[] args){
                Console.Clear();
                Menu();
        }

        static void Menu(){
            Console.WriteLine("Bem vindo ao menu de opções");
            Console.WriteLine("--------------------");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potenciacao");
            Console.WriteLine("6 - Sair");
            short inputUser = short.Parse(Console.ReadLine());

            switch(inputUser){
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Potenciacao(); break;
                case 6: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

        }

        static void Soma(){
            Console.WriteLine("Digite o primeiro valor que deseja somar:");
            float primeiroInput = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor para ser somado:");
            float segundoInput = float.Parse(Console.ReadLine());
            Console.WriteLine($"o resultado da operação é {primeiroInput + segundoInput}");
            Menu();
        }
        static void Subtracao(){
            Console.WriteLine("Digite o primeiro valor que deseja subtrair:");
            float primeiroInput = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor para ser subtraído:");
            float segundoInput = float.Parse(Console.ReadLine());
            Console.WriteLine($"o resultado da operação é {primeiroInput - segundoInput}");
            Menu();
        }
        static void Multiplicacao(){
            Console.WriteLine("Digite o primeiro valor que deseja multiplicar:");
            float primeiroInput = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor para ser multiplicado:");
            float segundoInput = float.Parse(Console.ReadLine());
            Console.WriteLine($"o resultado da operação é {primeiroInput * segundoInput}");
            Menu();
        }
        static void Divisao(){
            Console.WriteLine("Digite o primeiro valor que deseja dividir:");
            float primeiroInput = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor para ser dividido:");
            float segundoInput = float.Parse(Console.ReadLine());
            Console.WriteLine($"o resultado da operação é {primeiroInput / segundoInput}");
            Menu();
        }
        static void Potenciacao(){
            Console.WriteLine("Digite o primeiro valor que deseja potenciar:");
            float primeiroInput = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor para ser elevado:");
            float segundoInput = float.Parse(Console.ReadLine());
            Console.WriteLine($"o resultado da operação é {Math.Pow(primeiroInput,segundoInput)}");
            Menu();
        }
    }



}


