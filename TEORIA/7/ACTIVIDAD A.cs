using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.1416;
            int r = 0;
            double suma;

            Console.WriteLine("Ingrese un valor este se sumara con pi ");
            r = Int32.Parse(Console.ReadLine());

            suma = r + PI;

            Console.WriteLine("lA SUMA ES : " + suma);
            Console.ReadKey();
        }
    }
}
