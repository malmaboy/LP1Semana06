using System;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            program.Run();
        }

        private void Run()
        {
            Console.WriteLine("Insert the number of Enemies");
            int enemiesAmount = Int32.Parse(Console.ReadLine());

            Enemy[] enemies = new Enemy[enemiesAmount];

            
            for (int i = 0; i < enemiesAmount; i++)
            {
                Console.WriteLine("Insert the enemy Name");
                string name = Console.ReadLine();
                Enemy enemy = new Enemy(name);
                
                // Save the number of enemies in array
                enemies[i] = enemy;

            }

            Console.WriteLine("Enemies Names!");
            foreach (Enemy enemy in enemies)
            {
                Console.WriteLine(enemy.Name);
            }
            
            enemies[0].PickUpPowerUp(PowerUp.Health, 80);
            enemies[0].TakeDamage(50);

            Console.WriteLine($" health = {enemies[0].Health} \n " +
                              $"shield = {enemies[0].Shield} \n " +
                              $" name = {enemies[0].Name}");
            
            
        }
    }
}
