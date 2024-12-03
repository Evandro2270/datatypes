using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                SByte x = 100;
                byte n1 = 254;
                int n2 = 1000;
                int n3 = 2147483647;
                long n4 = 21474836478L;
                bool n5 = false;
                char n6 = 'F';
                char n7 = '\u0041';
                float n8 = 4.5f;
                double n9 = 4.5;
                string n10 = "Maria Clara";
                object n11 = "Alex Green";
                object n12 = 4.5f;    

                Console.WriteLine(x);
                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.WriteLine(n3);
                Console.WriteLine(n4);
                Console.WriteLine(n5);
                Console.WriteLine(n6);
                Console.WriteLine(n7);
                Console.WriteLine(n8);
                Console.WriteLine(n9);
                Console.WriteLine(n10);
                Console.WriteLine(n11);
                Console.WriteLine(n12);
            }
        }
    }
}