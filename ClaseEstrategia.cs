using System;
using System.Collections.Generic;
namespace TP_obligatorio
{
	
	public class Estrategia
	{
		//atributos
		private Planeta botPlaneta;
		
		
		//constructor
		public Estrategia(Planeta botPlaneta)
		{
			BotPlaneta=botPlaneta;
		}
		
		//metodos
		public string CalcularMoviemiento (ArbolGeneral<Planeta> arbol, Planeta BotPlaneta)//cuerpo de la estrategia
		{
			//calcular descendientes del planeta raiz del jugador
			//a partir de esa lista calcular que planeta me conviene atacar
			//realizar el moviemiento, ese planeta pasa a ser del bot y se suman las flotas
			//necesito reaizar una operacion en caso de que el jugador elimine un planeta bot, entonces debe cambiar mi raiz a algun hijo
					
		}
		
		public string Consulta1(ArbolGeneral<Planeta> arbol, Planeta botPlaneta, Planeta planeta)//en el progra deberia devolver mensaje adecuado
		{
    		List<string> camino = ObtenerCamino(arbol, botPlaneta, planeta);
    		return camino;
		}
		
		public string Consulta2(ArbolGeneral<Planeta> arbol)
		{
			List<string> planetasDescendientes = ObtenerDescendientes(arbol, BotPlaneta);
        		return "Planetas en los descendientes del nodo del Bot: " + string.Join(", ", planetasDescendientes);
		}
		
		public string Consulta3(ArbolGeneral<Planeta> arbol)
		{
			Cola<ArbolGeneral<T>> cola = new Cola<ArbolGeneral<T>>();
    			cola.Encolar(this);
	    		cola.Encolar(null);

    			int nivel = 0;
    			Console.WriteLine("Nivel: {0}", nivel);

    			int poblacionTotal = 0; // Inicializar la población total

    			while (cola.Count > 0)
    			{
        			var nodoActual = cola.Desencolar();

        			if (nodoActual == null)
        			{
            				if (cola.Count > 0)
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
            				poblacionNivel += ObtenerPoblacion(nodoActual.Dato);

            				if (nodoActual.Hijos != null)
            				{
                				foreach (var hijo in nodoActual.Hijos)
                				{
                    					cola.Encolar(hijo);
                				}
            				}
        			}
    			}
		}
		
			
		
		private List<string> ObtenerDescendientes(arbol, Botplaneta) //devuelve una lista con los hijos de determinado planeta
		{
			List<Planeta> planetasEnPreorden = new List<Planeta>();
    			RecorridoPreorden(arbol, planetaBot, planetasEnPreorden);

    			
    			List<string> nombresPlanetasEnPreorden = planetasEnPreorden.Select(p => p.Nombre).ToList();

    			// Convierte la lista de nombres en un string separado por comas con el join
    			string listaPlanetasEnPreorden = string.Join(", ", nombresPlanetasEnPreorden);

    			return listaPlanetasEnPreorden;
		}
		
		private List<string> ObtenerCamino(ArbolGeneral<Planeta> arbol, Planeta botPlaneta, Planeta planetaActual)
		{
    		if (planetaActual == null)
        	return null;

    		if (planetaActual.Equals(botPlaneta))
        	return new List<string> { planetaActual.nombre };  // Encontramos el planeta, retornamos una lista con su nombre

    		foreach (var hijo in arbol.ObtenerHijos(planetaActual))
    		{
        		var resultadoHijo = ObtenerCamino(arbol, botPlaneta, hijo.Dato);
        		if (resultadoHijo != null)
        		{
            			resultadoHijo.Insert(0, planetaActual.nombre);  // Agregamos el nombre del planeta actual al camino
            			return resultadoHijo;
        		}
   			}

    			return null;
		}
		
	}
}
