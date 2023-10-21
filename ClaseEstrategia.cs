using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	
	public class Estrategia<T>
	{
		//atributos
		private Planeta BotPlaneta;
		private int turnos;
  
		//constructor
		public Estrategia(Planeta botPlaneta, int turnos)
		{
 			BotPlaneta=botPlaneta;
    			this.turnos=turnos;
		}
		
		//metodos
  		public string CalcularMoviemiento (ArbolGeneral<Planeta> arbol, Planeta BotPlaneta, Planeta planetaJugador)//cuerpo de la estrategia
		{
			// Calcular descendientes del planeta raíz del jugador
    			List<Planeta> descendientes = ObtenerDescendientes(arbol, planetaJugador);

    			// Encontrar el planeta con la menor población entre los descendientes
   			Planeta planetaObjetivo = EncontrarPlanetaMenorPoblacion(descendientes);

    			// Cambios de las flotas y eliminacion del planeta del jugador
    			RealizarMovimiento(BotPlaneta, planetaObjetivo,arbol);
    		
    			string nombreConquista=planetaObjetivo.ObtenerNombre();
       
       			//disminuir turnos
       			turnos--;
	  		if (turnos=0)
     			{
				console.Writeline("no tienes mas turnos");
    				VerificarVictoria(arbol)
			}
    		    		
    			string mensaje = string.Format("Se realizo correctamente la conquista del planeta: {0}", nombreConquista);
    			return mensaje;
		}
		
		public string Consulta1(ArbolGeneral<Planeta> arbol, Planeta botPlaneta, Planeta planeta)
		{
    			List<string> camino = ObtenerCamino(arbol, botPlaneta, planeta);
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
		
		
		public List<Planeta> ObtenerDescendientes(ArbolGeneral<Planeta> arbol, Planeta planeta)
		{
    			List<Planeta> nombresDescendientes = new List<Planeta>();
    			ObtenerDescendientes(arbol, planeta);
    			return nombresDescendientes;
		}
		
		
		private List<string> ObtenerCamino(ArbolGeneral<Planeta> arbol, Planeta botPlaneta, Planeta planetaActual)
		{
    			if (planetaActual == null)
        		return null;

    			if (planetaActual.Equals(botPlaneta))
    			return new List<string> {planetaActual.ObtenerNombre()};  // Encontramos el planeta, retornamos una lista con su nombre

    			foreach (var hijo in arbol.getHijos(botPlaneta))
    			{
        			var resultadoHijo = ObtenerCamino(arbol, botPlaneta, hijo);
        			if (resultadoHijo != null)
        			{
            				resultadoHijo.Insert(0, planetaActual.ObtenerNombre());  // Agregamos el nombre del planeta actual al camino
            				return resultadoHijo;
        			}
   			}

    		return null;
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
