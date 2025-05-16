using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaOrdenada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2, nombre3;
            double nota1, nota2, nota3;

            Console.WriteLine("Ingrese el nombre y nota del Parcial N° 1");
            nombre1 = Console.ReadLine();
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre y nota del Parcial N° 2");
            nombre2 = Console.ReadLine();
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre y nota del Parcial N° 3");
            nombre3 = Console.ReadLine();
            nota3 = Convert.ToDouble(Console.ReadLine());

            if (nota1 > nota2)
            {
                if (nota3 > nota1)
                {
                    Console.WriteLine("El orden de notas es: " + nombre3 + " - " + nota3 + ", " + nombre1 + " - " + nota1 + ", " + nombre2 + " - " + nota2);
                }
                else
                {
                    if (nota3 > nota2)
                    {
                        Console.WriteLine("El orden de notas es: " + nombre1 + " - " + nota1 + ", " + nombre3 + " - " + nota3 + ", " + nombre2 + " - " + nota2);
                    }
                    else
                    {
                        Console.WriteLine("El orden de notas es: " + nombre1 + " - " + nota1 + ", " + nombre2 + " - " + nota2 + ", " + nombre3 + " - " + nota3);
                    }
                }
            }
            else
            {
                if (nota3 > nota2)
                {
                    Console.WriteLine("El orden de notas es: " + nombre3 + " - " + nota3 + ", " + nombre2 + " - " + nota2 + ", " + nombre1 + " - " + nota1);
                }
                else
                {
                    if (nota3 > nota1)
                    {
                        Console.WriteLine("El orden de notas es: " + nombre2 + " - " + nota2 + ", " + nombre3 + " - " + nota3 + ", " + nombre1 + " - " + nota1);
                    }
                    else
                    {
                        Console.WriteLine("El orden de notas es: " + nombre2 + " - " + nota2 + ", " + nombre1 + " - " + nota1 + ", " + nombre3 + " - " + nota3);
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
