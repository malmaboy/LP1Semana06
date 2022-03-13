using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p;
            p = new Program();
            p.CountTo10();
            p.CountTo10();

            Console.WriteLine("Insert the number to Count");

            int number = int.Parse(Console.ReadLine());
            p.CountToN(number);
            Console.WriteLine("Insert the number to Count");
            int number2 = int.Parse(Console.ReadLine());
            p.CountToN(number2);
            p.CountToN(10,20);
        }

        private void CountTo10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        private void CountToN(int _n)
        {
            for (int i = 0; i <= _n; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_n1"></param>
        /// <param name="_n2"></param>
        private void CountToN(int _n1, int _n2)
        {
            for (_n1 = _n1; _n1 < _n2; _n1++)
            {
                Console.WriteLine(_n1);
            }
        }
    }
}
