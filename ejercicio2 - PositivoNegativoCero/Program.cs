using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositivoNegativoCero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0) { Console.WriteLine("El número es Negativo"); }
            else
            {
                if (num == 0) { Console.WriteLine("El número es Cero"); }
                else { Console.WriteLine("El número es Positivo"); }
            }

            Console.ReadKey();
        }
    }
}
