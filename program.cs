using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Crear planetas para la IA
            		Planeta planetaIA1 = new Planeta("Azul", "IA1", 1000, 300, 10);
            		Planeta planetaIA2 = new Planeta("Azul", "IA2", 1500, 220, 15);
            		Planeta planetaIA3 = new Planeta("Azul", "IA3", 1325, 300, 12);
           		Planeta planetaIA4 = new Planeta("Azul", "IA4", 1100, 500, 18);
            		Planeta planetaIA5 = new Planeta("Azul", "IA5", 990, 700, 22);
			Planeta planetaIA6 = new Planeta("Azul", "IA6", 990, 700, 22);
           		
			// Crear el árbol para la IA
            		ArbolGeneral<Planeta> arbolIA = new ArbolGeneral<Planeta>(planetaIA1, new List<Planeta> { planetaIA2 });
            		arbolIA.AgregarHijo(planetaIA3);
            		arbolIA.AgregarHijoAunDeterminadoNodo(planetaIA2,planetaIA4);
            		arbolIA.AgregarHijoAunDeterminadoNodo(planetaIA2,planetaIA5);
            		arbolIA.AgregarHijoAunDeterminadoNodo(planetaIA2,planetaIA6);
				
				
            		// Crear planetas para el jugador
            		Planeta planetaJugador1 = new Planeta("Rojo", "Jugador1", 1200, 300, 12);
           		Planeta planetaJugador2 = new Planeta("Rojo", "Jugador2", 1800, 220, 18);
            		Planeta planetaJugador3 = new Planeta("Rojo", "Jugador3", 1000, 300, 10);
            		Planeta planetaJugador4 = new Planeta("Rojo", "Jugador4", 1350, 500, 15);
            		Planeta planetaJugador5 = new Planeta("Rojo", "Jugador5", 1440,700 , 12);

            		// Crear el árbol para el jugador
           		ArbolGeneral<Planeta> arbolJugador = new ArbolGeneral<Planeta>(planetaJugador1, new List<Planeta> { planetaJugador2 });
            		arbolJugador.AgregarHijo(planetaJugador3);
                        arbolJugador.AgregarHijoAunDeterminadoNodo(planetaJugador3,planetaJugador4);
            		arbolJugador.AgregarHijoAunDeterminadoNodo(planetaJugador3,planetaJugador5);
            
           	 	
            		Console.Write (arbolJugador.RecorridoPreorden());
            		Console.Write (arbolIA.RecorridoPreorden());
            
            		//consulta 1 para planeta de la IA
            		//consulta 2 para planeta de la IA
            		//consulta 3 para planeta de la IA
            		//calcular moviemiento para planeta de la IA
            
            		//consulta 1 para planeta del jugador
            		//consulta 2 para planeta del jugador
            		//consulta 3 para planeta del jugador
            		//calcular moviemiento para planetel jugado
        	
		}
	}
}
