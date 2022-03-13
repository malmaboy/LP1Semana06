using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p;
            p = new Program();
            Console.WriteLine("Insert the number for fibonacci");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(p.Fibonacci(number));
            
        }

        private int Fibonacci(int _n)
        {
            if (_n <= 2)
                return 1;
            else
                return Fibonacci(_n - 1) + Fibonacci(_n - 2);
            
        }
    }
}
