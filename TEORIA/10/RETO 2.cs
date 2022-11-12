using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETO_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aleatorio;
            int introducido;
            int restante;
            Console.WriteLine("Adivina el numero");

            Random generador = new Random();
            aleatorio = generador.Next(1, 100);

            restante = 10;
            do
            {
                Console.WriteLine("Intentos restantes: " + restante);
                Console.WriteLine("Dime un numero: ");
                introducido = Convert.ToInt32(Console.ReadLine());

                if (introducido > aleatorio)
                {
                    Console.WriteLine("te pasaste");
                }
                if(introducido < aleatorio)
                {
                    Console.WriteLine("te quedaste cerca");

                }
                restante --;
                
            } while ((introducido !=aleatorio)&&(restante > 0));

            if(introducido == aleatorio)
            {
                Console.WriteLine("acertaste felicidades");

            }
            else
            {
                Console.WriteLine("Era " + aleatorio);
            }
            Console.ReadKey();
        }
    }
}
