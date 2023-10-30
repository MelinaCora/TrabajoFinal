using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	
	public class Estrategia<T>
	{
		//atributos
		private Planeta BotPlaneta;
		//constructor
		public Estrategia()
		{
    		}
		
		//metodos
  		public string CalcularMoviemiento (ArbolGeneral<Planeta> arbol, Planeta BotPlaneta, Planeta planetaJugador)//cuerpo de la estrategia
		{
			// Encuentra el camino más corto desde BotPlaneta hasta planetaObjetivo
    			List<Planeta> caminoMasCorto = ObtenerCamino(arbol,planetaObjetivo);

    			if (caminoMasCorto != null)
    			{
        			// Realiza el movimiento de la flota a lo largo del camino
        			for (int i = 0; i < caminoMasCorto.Count - 1; i++)
        			{
            				Planeta planetaActual = caminoMasCorto[i];
            				Planeta planetaSiguiente = caminoMasCorto[i + 1];
        			}
        			string nombreConquista = planetaObjetivo.ObtenerNombre();
        			string mensaje = string.Format("Se realizó correctamente la conquista del planeta: {0}", nombreConquista);
        			return mensaje;
	    		}
        		else
   			{
        			// No se encontró un camino, devuelve un mensaje de error
        			return "No se pudo encontrar un camino hacia el objetivo.";
    			}
		}
		
		public string Consulta1(ArbolGeneral<Planeta> arbol, Planeta botPlaneta, Planeta planeta)
		{
    			List<Planeta> camino = ObtenerCamino(arbol, botPlaneta);
    			if (camino == null)
        		return "No se encontró un camino a ese planeta.";

    			return "Camino al planeta: " + string.Join(" -> ", camino);
		}
		
		public string Consulta2(ArbolGeneral<Planeta> arbol, Planeta planetaIA)//usar ObtenerDescendientes
		{
			List<Planeta> planetasDescendientes = ObtenerDescendientes(arbol, planetaIA);
        		return "Planetas en los descendientes del nodo del Bot: " + string.Join(", ", planetasDescendientes);
		}
		public void Consulta3(ArbolGeneral<Planeta> arbol)
		{
			//recorrido por niveles con separador realizando los calculos necesarios por nivel
   			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>();
    			cola.Encolar(arbol);
    			cola.Encolar(null);

    			int nivel = 0;
    			Console.WriteLine("Nivel: {0}", nivel);

    			int poblacionTotal = 0; // Inicializar la población total
    			int poblacionNivel =0;

    			while (cola.Contar() > 0)
    			{
        			var nodoActual = cola.Desencolar();

        			if (nodoActual == null)
        			{
        				if (cola.Contar() > 0)
            				{
                				cola.Encolar(null);
                				nivel++;
                				Console.WriteLine("\nNivel: {0}", nivel);

                				// Calcular población total y porcentaje
                				float porcentaje = poblacionTotal > 0 ? ((float)poblacionNivel / poblacionTotal) * 100 : 0;
                				Console.WriteLine("Población total en este nivel: {0}", poblacionNivel);
                				Console.WriteLine("Porcentaje respecto a la población total: {0:0.00}%", porcentaje);

                				// Reiniciar la población para el próximo nivel
                				poblacionNivel = 0;
            				}
       	 			}
        			else
        			{
            				// Agregar la población de este nodo al total del nivel
            				poblacionNivel += nodoActual.Dato.ObtenerPoblacion();

            				if (nodoActual.Hijos != null)
            				{
                				foreach (var hijo in nodoActual.Hijos)
                				{
                    					ArbolGeneral<Planeta> arbolHijo = new ArbolGeneral<Planeta>(hijo, null);
        						cola.Encolar(arbolHijo);
                				}
            				}
        			}
    			}
		}
		
		
		private List<Planeta> ObtenerDescendientes(ArbolGeneral<Planeta> arbol, Planeta planeta)
		{
    			List<Planeta> nombresDescendientes = new List<Planeta>();
    			ObtenerDescendientes(arbol, planeta);
    			return nombresDescendientes;
		}
		
		
		//obtener camino del bot hacia la raiz
		private List<Planeta> ObtenerCamino(ArbolGeneral<Planeta> arbol, Planeta planeta)
		{
    			List<Planeta> camino = new List<Planeta>();
    			Planeta nodoActual = planeta;
    			while (nodoActual != null)
    			{
        			camino.Add(nodoActual);
        			if (nodoActual.Equals(arbol.Dato))
            				break; // se corta una vez encontrada la raiz
    			}

    			camino.Reverse(); // Invertimos 
    			return camino;
		}
  
		private Planeta EncontrarPlanetaMenorFlotas(List<Planeta> descendientes)
		{
    			int menosFlotas = descendientes[0].ObtenerFlotas();
   	 		Planeta planetaMenorFlotas = descendientes[0];

    			foreach (var planetax in descendientes)
    			{
        			int flotasPlaneta = planetax.ObtenerFlotas();
        			if (flotasPlaneta < menosFlotas)
        			{
            				menosFlotas = flotasPlaneta;
            				planetaMenorFlotas = planetax;
        			}
    			}
    			return planetaMenorFlotas;
		}
  		//metodo para verificar quien tiene la victoria
  		public void VerificarVictoria(ArbolGeneral<Planeta> arbol)
    		{
      			int planetasIA=0);
	 		int planetasJugador=0;
    			//se crea una cola con todos los planetas
    			Cola<ArbolGeneral<Planeta>> cola = new Cola<ArbolGeneral<Planeta>>();
    			cola.Encolar(arbol);
    			cola.Encolar(null);
       			//mientras haya elementos en la cola
      			while (cola.Contar() > 0)
    			{
        			Recorrido por niveles del arbol
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
                    					cola.Encolar(new ArbolGeneral<Planeta>(hijo, null)); //los agrego a la cola para ser vicitados en el siguiente nivel.
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
