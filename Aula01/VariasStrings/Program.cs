using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;

            double xx = 0.12345;
            int ii = 18;
            
            string s = @"nao é um codigo Unicode \u1234, nao e’ nova linha \n";
            string another =
                "nao é um codigo Unicode \u1234, nao e’ nova linha \n";
            Console.WriteLine(s);
            Console.WriteLine(another);

            string a = "a" + "abc" + x;
            Console.WriteLine(a);
            Console.WriteLine($"Valor de x é {x}");
            Console.WriteLine($"{x} mais {y} é igual a {x + y}");

            String.Format("Y é {0}, X é {1}", y, x);
            Console.WriteLine(@"Verbatim com x = {0}", x);

            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");

            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");
        }
    }
}
