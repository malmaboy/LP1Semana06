using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            program.Run();
        }

        private void Run()
        {
            //Ex16();
           // Ex17();
           //Ex18();
           //Ex19();
           Ex20();
        }

        private void Ex16()
        {
            int number1 = Int32.Parse(Console.ReadLine());
            int number2 = Int32.Parse(Console.ReadLine());
            int number3 = Int32.Parse(Console.ReadLine());

            if (number1 + number2 == number3)
            {
                Console.WriteLine("É possivel :)");
            }
            else
            {
                Console.WriteLine("Impossível :(");
            }
        }

        private void Ex17()
        {
            int number1 = Int32.Parse(Console.ReadLine());

            if (number1 % 3 == 0)
                Console.WriteLine("Fizz!");
            
            else if(number1 % 5 == 0)
                Console.WriteLine("Buzz!");
            
            else if(number1 % 3 == 0|| number1 % 5 == 0)
                Console.WriteLine("FizzBuzz!");
            else
                Console.WriteLine($"{number1}!");
            
        }

        private void Ex18()
        {
            int i;
            string phrase = Console.ReadLine();
            
            for (i = 0; i < phrase.Length; i++)
            {
                
            }
            if (i > 20)
                Console.WriteLine("Too long to read!");
            else if (i >= 5 && i <= 20)
                Console.WriteLine("Ok, if you say so.");
            else if (i < 5)
                Console.WriteLine("That's not very meaningful, is it");

        }

        private void Ex19()
        {
            Console.WriteLine("Type the highScore");
            int currentHighScore = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type the new Score");
            int newScore = Int32.Parse(Console.ReadLine());

            Console.WriteLine(currentHighScore > newScore ? "New high Score" 
                : "Keep trying");
            
            

        }

        private void Ex20()
        {
            double d = 0.3513;
            float f = 12.645f;

            Console.WriteLine("d -> {0,5:f2}", d);
            Console.WriteLine("f -> {0,5:f2}", f);
            
            /* É impresso os números 0.35 e 12.64, isto, porque "0,5" é o alinhamento de espaços a direira e de seguida pedem o retorno de 2 casas decimais.
             * 
             */
        }
    }
}
