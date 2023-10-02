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
		
		public string Consulta3()
		{
			//recorrer por niveles
			//cada nivel tiene una lista de listas conformada por el nombre del planeta y su poblacion
			//utilizando el metodo de encolar para agregar los datos y sumarlos
			//se crea nueva lista por nivel
			//imprimir la informacion calculando el porcentaje
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
