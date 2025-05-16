using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreJugador1, nombreJugador2;
            int puntosJugador1, puntosJugador2, setJugador1, setJugador2;

            setJugador1 = 0;
            setJugador2 = 0;

            Console.WriteLine("Escriba el nombre de los dos jugadores");
            nombreJugador1 = Console.ReadLine();
            nombreJugador2 = Console.ReadLine();

            Console.WriteLine("Set 1 --------------------");
            Console.WriteLine("¿Cuantos puntos obtuvo el Jugador 1?");
            puntosJugador1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuantos puntos obtuvo el Jugador 2?");
            puntosJugador2 = Convert.ToInt32(Console.ReadLine());

            if (puntosJugador1 > puntosJugador2) { setJugador1++; }
            else { setJugador2++; }

            Console.WriteLine("Set 2 --------------------");
            Console.WriteLine("¿Cuantos puntos obtuvo el Jugador 1?");
            puntosJugador1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuantos puntos obtuvo el Jugador 2?");
            puntosJugador2 = Convert.ToInt32(Console.ReadLine());

            if (puntosJugador1 > puntosJugador2) { setJugador1++; }
            else { setJugador2++; }

            Console.WriteLine("Set 3 --------------------");
            Console.WriteLine("¿Cuantos puntos obtuvo el Jugador 1?");
            puntosJugador1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuantos puntos obtuvo el Jugador 2?");
            puntosJugador2 = Convert.ToInt32(Console.ReadLine());

            if (puntosJugador1 > puntosJugador2) { setJugador1++; }
            else { setJugador2++; }

            if (setJugador1 > setJugador2) { Console.WriteLine("El ganador es: " + nombreJugador1); }
            else { Console.WriteLine("El ganador es: " + nombreJugador2); }
            Console.ReadKey();
        }
    }
}
