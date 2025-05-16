using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñoBisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;

            Console.WriteLine("Escriba el año que desee comprobar:");
            año = Convert.ToInt32(Console.ReadLine());

            if (año % 4 == 0) 
            {
                if (año % 100 != 0 || año % 400 == 0)
                {
                    Console.WriteLine("El año es un Año Bisiesto!");
                }
                else
                {
                    Console.WriteLine("El año no corresponde a un Año Bisiesto.");
                }
            }
            else
            {
                Console.WriteLine("El año no corresponde a un Año Bisiesto.");
            }

            Console.ReadKey();
        }
    }
}
