using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Crear planetas para la IA
            Planeta planetaIA1 = new Planeta("Azul", "IA1", 1000, 500, 10);
            Planeta planetaIA2 = new Planeta("Azul", "IA2", 1500, 700, 15);

            // Crear el árbol para la IA
            ArbolGeneral<Planeta> arbolIA = new ArbolGeneral<Planeta>(planetaIA1, new List<Planeta> { planetaIA2 });

            // Crear planetas para el jugador
            Planeta planetaJugador1 = new Planeta("Rojo", "Jugador1", 1200, 600, 12);
            Planeta planetaJugador2 = new Planeta("Rojo", "Jugador2", 1800, 800, 18);

            // Crear el árbol para el jugador
            ArbolGeneral<Planeta> arbolJugador = new ArbolGeneral<Planeta>(planetaJugador1, new List<Planeta> { planetaJugador2 });
        	
		}
	}
}
