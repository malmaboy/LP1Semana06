using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ValoresEspeciais
{
    class Program
    {
        // Max Values                     
        int inteiroMax = Int32.MaxValue;  
        int inteiroMin = Int32.MinValue;  
        float singleMax = Single.MaxValue;
        float singleMin = Single.MinValue;
        private double doubleMax = Double.MaxValue;
        double doubleMin = Double.MinValue;
        byte byteMax = Byte.MaxValue;     
        byte byteMin = Byte.MinValue;     
        short shortMax = short.MaxValue;
        private short shortMin = short.MinValue;
        // Valores Especiais                                 
        float infinityPlus = Single.PositiveInfinity;        
        float infinityNegative = Single.NegativeInfinity;    
        float None = Single.NaN;                             
        static void Main(string[] args)
        {
            Program p;
            p = new Program();
            
        }

        private void Run()
        {
            PrintValues();
            Console.WriteLine("Overflow");
            Overflow();
        }

        private void PrintValues()
        {




            Console.WriteLine(inteiroMax + " " + inteiroMin);
            Console.WriteLine(singleMax+ " " + singleMin);
            Console.WriteLine(doubleMax + " " + singleMin);
            Console.WriteLine(byteMax + " " + byteMin);
            Console.WriteLine(shortMax + " " + shortMin);

           
           
           
           

            Console.WriteLine($" Valores Especiais {infinityPlus} \n {infinityNegative} \n {None}");
        }

        private void Overflow()
        {
            // Inteiros
            
        }
    }
}
