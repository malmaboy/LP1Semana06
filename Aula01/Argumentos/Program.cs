using System;

namespace Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index  < args.Length ; index++)
            {
                Console.WriteLine(args[index]);
            }
            
            foreach (string index in args)
            {
                Console.WriteLine(index);
            }
        }
    }
}
