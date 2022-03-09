using System;
using System.Collections.Generic;

namespace NPCPerks
{
    class Program
    {
        private  Perks[] perksToAdd;
        private Perks perk;
        
        static void Main(string[] args)
        {
            Program p;
            p = new Program();
            p.Run();
        }
        
        private void Run()
        {
            Console.WriteLine("Insert the number of NPCs");
            int npcsNumber = Int32.Parse(Console.ReadLine());

            Perks[][] asd = new Perks[npcsNumber][];
            
            
            // Add perks to NPCs
            for (int i = 0; i < asd.Length; i++)
            {
                asd[i] = perksToAdd;
                Console.WriteLine($"Hello {asd[i]}");
            }
            

            foreach (var p in asd)
            {
                
            }
            
            
            // Compare 

            /*
            foreach (Perks[] npc in asd)
            {
                foreach (var p in npc)
                {
                    p.
                }
            }*/

        }

        private Perks Method()
        {
            string perks = Console.ReadLine();


            if (perks == "Stealth")
                return perk = Perks.Stealth;
            
            if (perks == "Combat")
                 return perk = Perks.Combat;
            
            if (perks == "Lockpick")
                return perk = Perks.Lockpick;
            
            if (perks == "Luck")
                return perk = Perks.Luck;

            return 0;
        }
    }
    
    
}

[Flags]
enum Perks
{
    Stealth = 0,
    Combat = 1,
    Lockpick = 2,
    Luck = 4
}
