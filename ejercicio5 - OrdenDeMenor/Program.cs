using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenDeMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, menor, orden;

            Console.WriteLine("Ingrese el primer número");
            valor = Convert.ToInt32(Console.ReadLine());
            menor = valor;
            orden = 1;

            Console.WriteLine("Ingrese el segundo número");
            valor = Convert.ToInt32(Console.ReadLine());
            if (valor < menor) menor = valor;
            orden++;

            Console.WriteLine("Ingrese el tercer número");
            valor = Convert.ToInt32(Console.ReadLine());
            if (valor > menor) menor = valor;
            orden++;

            Console.WriteLine("Ingrese el cuarto número");
            valor = Convert.ToInt32(Console.ReadLine());
            if (valor > menor) menor = valor;
            orden++;

            Console.WriteLine("Ingrese el último número");
            valor = Convert.ToInt32(Console.ReadLine());
            orden++;

            Console.WriteLine("El orden del menor número que se ingresó fué: Orden " + orden);
            Console.ReadKey();
        }
    }
}
