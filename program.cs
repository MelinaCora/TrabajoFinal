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
				
				
            		// Crear planetas para el jugador
            		Planeta planetaJugador1 = new Planeta("Rojo", "Jugador1", 1200, 300, 12);
            		Planeta planetaJugador2 = new Planeta("Rojo", "Jugador2", 1800, 220, 18);
            		Planeta planetaJugador3 = new Planeta("Rojo", "Jugador3", 1000, 300, 10);
            		Planeta planetaJugador4 = new Planeta("Rojo", "Jugador4", 1350, 500, 15);
            		Planeta planetaJugador5 = new Planeta("Rojo", "Jugador5", 1440,700 , 12);
            		Planeta planetaJugador6 = new Planeta("Rojo", "Jugador6", 1800, 220, 18);
           
            		// Crear planetas neutrales
            		Planeta planetaNeutral1 = new Planeta("Blanco", "Neutral1", 1000, 300, 10);
            		Planeta planetaNeutral2 = new Planeta("Blanco", "Neutral2", 1500, 220, 15);
            		Planeta planetaNeutral3 = new Planeta("Blanco", "Neutral3", 1325, 300, 12);
            		Planeta planetaNeutral4 = new Planeta("Blanco", "Neutral4", 1100, 500, 18);
            		Planeta planetaNeutral5 = new Planeta("Blanco", "Neutral5", 990, 700, 22);
            		Planeta planetaNeutral6 = new Planeta("Blanco", "Neutral6", 990, 700, 22);
            		//armo el arbol general
                        //ciclo de juego
			//Movimiento Juego1 = new Movimiento(planeta origen , planeta destino, arbol);
			//juego1.RealizarMoviemiento(planetaIA, planetaDestino, arbol);
			//VerificarVictoria(arbol);
			//consulta1
            		//consulta2
            		//consulta3
            		//CalcularMovimiento
           		 
            		private void VerificarVictoria(ArbolGeneral<Planeta> arbol)
	    		{
      				int planetasIA=0;
	 			int planetasJugador=0;
    				//se crea una cola con todos los planetas . Recorrido por niveles
    				Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>();
    				cola.Encolar(arbol);
    				cola.Encolar(null);
       				//mientras haya elementos en la cola
      				while (cola.Contar() > 0)
    				{
        			//Recorrido por niveles del arbol
	   			var nodoActual = cola.Desencolar();
	       			if (nodoActual == null) // si el nodo es null entonces es nivel
        			{
            				if (cola.Contar() > 0)
            				{
                				cola.Encolar(null);
            				}
        			}
        			else // si no es null entonces pregunto si es de la ia o del jugador
        			{
            				if (nodoActual.Dato.EsPlanetadelaIA())
            				{
                				planetasIA++; //agrego al contador
            				}
            				else if (nodoActual.Dato.EsPlanetadelJugador())
            				{
                				planetasJugador++; //Agrego al contador
            				}

            				if (nodoActual.Hijos != null) //verifico si ese nodo tiene hijos
            				{
                				foreach (var hijo in nodoActual.Hijos) // si tiene los recorro
               		 			{
                    					cola.Encolar(new ArbolGeneral<Planeta>()); //los agrego a la cola para ser vicitados en el siguiente nivel.
                				}
            				}
        			}
	   			if (planetasIA > planetasJugador) // comparo ambos contadores
    				{
        				Console.WriteLine("La IA ha ganado.");
    				}
    				else if (planetasJugador > planetasIA)
    				{
        				Console.WriteLine("El jugador ha ganado.");
    				}
   	 			else
    				{
        				Console.WriteLine("El juego ha terminado en empate.");
    				}
   	 		}
		}
	}
}
}
