using System;
using System.Collections.Generic;

namespace ArrayBiDim
{
    class Program
    {
        private int dimX, dimY = 0;

        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            program.Run();
        }

        private void Run()
        {
            int n = 0;
            float average = 0;


            Console.WriteLine("Insert horizontal  Value");
            int horizontal = Int32.Parse((Console.ReadLine()));
            Console.WriteLine("Insert vertical Value");
            int vertical = Int32.Parse(Console.ReadLine());

            float[,] arrayBi = new float[horizontal, vertical];

            // Add Values to horizontal 
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                for (int j = 0; j < arrayBi.GetLength(1); j++)
                {
                    Console.WriteLine("Insert the values");
                    int value = Int32.Parse(Console.ReadLine());

                    arrayBi[i, j] = value;

                    dimX = i;
                    dimY = j;
                    
                    // Shows the array 
                    Console.WriteLine(
                        $"Position [{dimX}, {dimY}] = {arrayBi[dimX, dimY].ToString()}");
                   
                }
               
            }

         

            


            // Average per row
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                float averageRow = 0;

                for (int j = 0; j < arrayBi.GetLength(1); j++)
                {
                    averageRow += arrayBi[i, j];
                }

                average = average + (averageRow / arrayBi.GetLength(1));

                Console.WriteLine(
                    $"Average per Row number : {n++}  Average {averageRow / arrayBi.GetLength(1)}");
            }

            // Sum of average

            Console.WriteLine($"Average = {average}");
        }
    }
}