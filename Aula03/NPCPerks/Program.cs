using System;
using System.Collections.Generic;

namespace NPCPerks
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
            int n = 1;
            Console.WriteLine("Insert the number of npcs");
            int npcsNumber = Int32.Parse(Console.ReadLine());

            Perks[] perksList = new Perks[npcsNumber];

            for (int i = 0; i < npcsNumber; i++)
            {
                
                Console.WriteLine("Insert the number of perks by spaces [Stealth] [Combat] [Lockpick] [Luck] :");

                string[] perks = Console.ReadLine().ToLower().Split( ' ');

                

                for (int j = 0; j < perks.Length; j++)
                {
                    switch (perks[j])
                    {
                        case "stealth":
                            perksList[i] = Perks.Stealth;
                            break;
                        case "combat":
                            perksList[i] = Perks.Combat;
                            break;
                        case "lockpick":
                            perksList[i] = Perks.Lockpick;
                            break;
                        case "luck":
                            perksList[i] = Perks.Luck;
                            break;
                        default:
                            Console.WriteLine("Unknown value!");
                            break;
                    }

                    
                }

                
            }

            for (int i = 0; i < npcsNumber; i++)
            {
                Console.WriteLine($"NPC has {i} has {perksList[i]}");
            }




        }

    }
    
    
}

[Flags]
enum Perks
{
    Stealth = 1,
    Combat = 2,
    Lockpick = 4,
    Luck = 8
}
