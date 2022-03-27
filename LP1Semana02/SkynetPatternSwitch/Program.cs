using System;

namespace SkynetPatternSwitch
{
    class Program
    {
        //private string response, question;

        static void Main(string[] args)
        {
            Program p;
            p = new Program();
            
            p.Run();
        }

        private void Run()
        {
            Console.WriteLine("What is your question");
            string question = Console.ReadLine();

            string response = question switch
            {
                "How are you?" => "I'm fine, thank you.",
                "What's your name?" => "Skynet",
                "What's your mission" => "Destroy mankind",
                _ => "You got me, I'm not THAT smart!"
            };

            Console.Write(response);
        }
    }
}
