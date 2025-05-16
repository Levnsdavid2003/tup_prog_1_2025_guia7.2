using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, mayor;

            Console.WriteLine("Ingrese el primer número");
            valor = Convert.ToInt32(Console.ReadLine());
            mayor = valor;

            Console.WriteLine("Ingrese el segundo número");
            valor = Convert.ToInt32(Console.ReadLine());
            if (valor > mayor) mayor = valor;

            Console.WriteLine("Ingrese el tercer número");
            valor = Convert.ToInt32(Console.ReadLine());
            if (valor > mayor) mayor = valor;

            Console.WriteLine("Ingrese el cuarto número");
            valor = Convert.ToInt32(Console.ReadLine());
            if (valor > mayor) mayor = valor;

            Console.WriteLine("Ingrese el último número");
            valor = Convert.ToInt32(Console.ReadLine());
            if (valor > mayor) mayor = valor;

            Console.WriteLine("El número mayor de los 5 es: " + mayor);
            Console.ReadKey();
        }
    }
}
