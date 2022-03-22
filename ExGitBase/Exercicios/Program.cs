using System;
using System.Linq;

namespace Exercicios
{
    class Program
    {
        const int maxTurns = 20;
        int turn = 0;
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            program.Run(args);
        }

        private void Run(string[] _args)
        {
            //Ex16();
           // Ex17();
           //Ex18();
           //Ex19();
           //Ex20();
           
           //Ex25();
          // Ex28(_args);
          //Ex33();
          Ex34();
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
        
        private void Ex21()
        {
            double x = 0.1592;
            double y = 1.1231;

            Console.WriteLine($"x igual a {x,6:p1}");
            Console.WriteLine($"y igual a {y,6:p1}");
            
            /**/
        }

        private void Ex22()
        {
            int a = 10;
            int b = 100;
            int c = 1000;

            string s1 = String.Format("{0,4}", a);
            string s2 = String.Format("{0,4}", b);
            string s3 = String.Format("{0,4}", c);

            Console.WriteLine(s1 + "\n" + s2 + "\n" + s3);
            
            /**/
        }

        private void Ex25()
        {
            
            turn++;
            
            if (turn >= maxTurns)
            {
                Console.WriteLine($"last turn was {turn}");
            }
            else if (turn <= maxTurns)
            {
                Console.WriteLine($"turn number {turn}");
                Ex25();     
            }
                

            if (turn % 3 == 0)
            {
                Ex25();
            }
            

        }

        private void Ex28(string[] _args)
        {
            int[] x = new int[0];
            int media = 0;
            int mediana = 0;

            for (int j = 0; j < _args.Length; j++)
            {
                x = new int[j];
            }
            
            // Media
            for (int i = 0; i < x.Length; i++)
            {
                media += x[i];
               // mediana = 
            }

            string s = Console.ReadLine();
            
            switch (s)
            {
                case "media":
                    
                    break;
            }
        }


        private void Ex33()
        {
            int[] someInts = { 11, 8, 6, 3, 9, 104 };

            foreach (int v in someInts)
            {
                if (v % 2 == 0)
                {
                    Console.WriteLine("{0,3}", v);
                }
            }

            
        }

        private void Ex34()
        {
            int n = 0;

            string[] frases = {
                "Curta",
                "Uma frase longa",
                "Small",
                "Very large sentence",
                "Petit",
                "How many words do I have?"
            };

            foreach (string s in frases)
            {
                if (s.Length > 6)
                {
                    n++;
                }
            }

            Console.WriteLine(n);
            
        }

        private void Ex38()
        {
            int[] number;
            int n = 10;

            number = test(n);
        }

        private int[] test(int n)
        {
            int[] value = new int[n];
            for (int i = 1; i < n; i++)
            {
                value[i] = i;
                
            }

            return value;
        }
    }  
    
    
}

