using System;
using System.Linq;

namespace PercorreString
{
    class Program
    {
        private string result;
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            program.Run();
        }

        private void Run()
        {
            
            
            Console.WriteLine("Insert a phrase.");
            string phrase = Console.ReadLine();
            Console.WriteLine("Insert a character.");
            string c = Console.ReadLine()?.Substring(0,1);
            result = phrase.Replace(c, "");
            Console.WriteLine(result);

            
        }
    }
}
