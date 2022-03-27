using System;

namespace Cilindro
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
            Cilindro();
        }

        private void Cilindro()
        {
            Console.WriteLine("Insira a altura do cilindro");
            float altura = Single.Parse(Console.ReadLine());
            Console.WriteLine("Insira o raio do Cilindro");
            float raio = Single.Parse(Console.ReadLine());

            float volume = MathF.PI * MathF.Pow(raio, 2) * altura;

            float superficie = 2 * MathF.PI * raio * (raio * altura);

            Console.WriteLine($"Volume = {volume} \n Superfice = {superficie}");
        }
    }
}
