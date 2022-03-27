using System;

namespace ChatBot
{
    class Program
    {
        private string question;
        private bool continueCicle;

        private Program()
        {
            continueCicle = true;
        }

        static void Main(string[] args)
        {
            Program p;
            p = new Program();
            p.Run();
        }

        private void Run()
        {
            
            while (continueCicle)
            {
                Console.WriteLine("You can ");
                question = Console.ReadLine();
                
                switch (question)
                {
                    case "EXIT":
                        continueCicle = false;
                        break;
                    case"How are you?":
                        Console.WriteLine("I'm fine and you mister human?");
                        break;
                    case"What is you plan?":
                        Console.WriteLine("Just talk with humans, just for fun.");
                        Console.WriteLine(">:)");
                        break;
                    case "What is your name?":
                        Console.WriteLine("I'm bot, Chatbot.");
                        break;
                    default:
                        Console.WriteLine("I don't know the answer  for that!");
                        break;
                    
                }
            }
        }
    }
}
