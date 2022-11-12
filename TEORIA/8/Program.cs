using System;

namespace EJERCICIO_EN
{
    class Program
    {
        static void Main(string[] args)
        {
            int cancion = 100;
            int letra = 100;
            int letra2 = 99;
            Console.WriteLine("Ingresen la letra de la cancion");
            for (int i = 1; i <= 99; i++)
            {
                cancion = cancion - 1;
                letra = letra - 1;
                letra2 = letra2 - 1;
                Console.WriteLine(+cancion + "  bottles of pop on the wall " + letra + " bottles of pop If one of those bottles should happen to fall, " + letra2 + " bottles of pop on the wall");
            }
        }
    }

}
