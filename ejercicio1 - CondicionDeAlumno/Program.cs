using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionDelAlumno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double condicion, p1, p2, p3, prom;

            Console.WriteLine("Ingrese la nota de condición de aprobación:");
            condicion = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese las tres notas a evaluar:");
            p1 = Convert.ToDouble(Console.ReadLine());
            p2 = Convert.ToDouble(Console.ReadLine());
            p3 = Convert.ToDouble(Console.ReadLine());

            prom = (p1 + p2 + p3) / 3;

            if (prom >= condicion) { Console.WriteLine("El alumno Promociona"); }
            else { Console.WriteLine("El alumno Rinde Final"); }
            Console.ReadKey();
        }
    }
}
