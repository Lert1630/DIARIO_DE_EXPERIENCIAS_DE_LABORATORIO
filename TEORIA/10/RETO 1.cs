using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SolicitarDatos();
            Console.ReadKey(true);
            
        }
        static int calcularEdad(int añoAc, int añoNac)
        {
            int edad;
            string nombre, deporte, cancion, herma;

            edad = añoAc - añoNac;

            return edad;
        }
        static int SolicitarDatos()
        {
            int aa, an;
            string nombre, deporte, cancion, herma;
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese deporte favorito: ");
            deporte = Console.ReadLine();
            Console.WriteLine("Ingrese cancion favorita: ");
            cancion = Console.ReadLine();
            Console.WriteLine("Ingrese cuantos hermanos tiene: ");
            herma = Console.ReadLine();
            Console.WriteLine("Ingresar el año actual: ");
            aa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresar el año de nacimineto: ");
            an = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("tu edad es: " + calcularEdad(aa, an));
            Console.WriteLine("Tu nombre es " + nombre + " tu deporte favorito es " + deporte + " tu cancion es " + cancion + " tienes " + herma + " hermanos" + " tu edad " + calcularEdad(aa, an));

            return 0;
        }
        
        

        }
        

        }
 

