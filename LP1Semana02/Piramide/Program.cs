using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p;
            p = new Program();
            p.Run();
        }

        private void Run()
        {
            Console.WriteLine("Insert the number of lines");
            int lines = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                for (int space = 1; space <= (lines - i); space++)
                    Console.Write(" ");
                for (int number = 1; number <= i; number++)
                    Console.Write('*');
                for (int number = (i-1); number >= 1; number--)
                    Console.Write('*');

                Console.WriteLine();
                    
                
            }
        }
    }
}

