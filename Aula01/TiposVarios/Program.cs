using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            // integral variables
            int numberInt = -10;
            uint numberUInt = 10u;

            Console.WriteLine(numberInt + " " + numberUInt );

            short numberShort = -200;
            ushort numberUShort = 200;
            
            Console.WriteLine(numberShort + " " + numberUShort );

            long numberLong = -1000000l;
            ulong numberULong = 100000l;
            
            Console.WriteLine(numberLong + " " + numberULong );

            byte numberByte = 1;
            sbyte numberSByte = 127;
            
            Console.WriteLine(numberByte + " " + numberSByte );
            
            // Float Varibles
            float numberFloat = 3.1514f;
            double numberDouble = 3.131414;
            
            Console.WriteLine(numberFloat + " " + numberDouble );
            
            // Decimal Variables
            decimal numberDecimal = 10000m;
            Console.WriteLine(numberDecimal );
            
            // Bool variables
            bool on = true;
            bool off = false;

            Console.WriteLine(on + " " + off);
        }
    }
}
