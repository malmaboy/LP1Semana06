using System;
using System.Linq;
using System.Security.Cryptography;

namespace ExerciciosAula
{
    class Program
    {
        private int exNumber;
        private string input;

        static void Main(string[] args)
        {
            Program program;
            program = new Program();

            program.Run(args);
        }

        private void Run(string[] _args)
        {
            Console.WriteLine("Insert the exercise number! \n" );
            exNumber = int.Parse(Console.ReadLine());
            switch (exNumber)
            {
                case 10:
                    Ex10();
                    break;
                case 11:
                    Ex11();
                    break;
                case 12:
                    Ex12();
                    break;
                case 13:
                    Ex13();
                    break;
                case 14:
                    Ex14();
                    break;
                case 15:
                    Ex15(_args);
                    break;
                default:
                    break;
            }
        }

        private void Ex10()
        {
            Console.WriteLine("Exercicio 10");
            Console.WriteLine("Write Something in the console");

            string input = Console.ReadLine();
            Console.WriteLine($"You wrote this : {input}");
        }

        private void Ex11()
        {
            Console.WriteLine("Exercicio 11");
            Console.WriteLine(
                "White something in the console and will be inverse");

            string input = Console.ReadLine();
            char[] c = input.ToCharArray();

            foreach (char c1 in c.Reverse())
            {
                Console.Write(c1);
            }
        }

        private void Ex12()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Sum =  {number1 + number2}");
        }

        private void Ex13()
        {
            Int64 x = int.Parse(Console.ReadLine());
            Int64 y = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(x, y));
        }

        private void Ex14()
        {
            float comprimento = float.Parse(Console.ReadLine());
            float altura = float.Parse(Console.ReadLine());
            float largura = float.Parse(Console.ReadLine());

            Console.WriteLine($"Volume = {comprimento * altura * largura}");
        }

        private void Ex15(string[] _args)
        {
            for (int index = 0; index < _args.Length; index++)
            {
                Console.WriteLine(_args[index]);
            }

            foreach (string index in _args)
            {
                Console.WriteLine(index);
            }
        }
    }
}