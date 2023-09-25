
using System;
using System.Collections;

namespace TP_obligatorio
{
	
	public class Movimiento
	{
		//atributos
		private Planeta planetaOrigen {get; set;}
		private Plaeta planetaDestino {get;set;}
		
		//constructor
		public Movimiento(Planeta origen;Planeta destino;ArbolGeneral <Planeta> arbol;);
		{
			Planeta origen=planetaOrigen;
			Planeta destino= planetaDestino;
			
		}
		
		//metodo para hallar el planeta mas cercano
		private Planeta PlanetaMasCercano(ArbolGeneral <Planeta> arbol; Planeta o; Planeta d;){
			//REcorrer el arbol  desde un nodo hasta otro comparano si el planeta d tiene menos naves que el o 
	    	{
        	Planeta planetaMasCercano = origen;
        	foreach (var hijo in nodoActual.Hijos)
        	{
            	// Llamar recursivamente a la función para cada hijo
            	Planeta planetaHijoMasCercano = PlanetaMasCercano(hijo, origen, destino);

            	// Comparar el número de naves del planeta más cercano actual con el del hijo
            	if (planetaHijoMasCercano != null && planetaHijoMasCercano.Naves < planetaMasCercano.Naves)
            	{
                	planetaConveniente = planetaHijoMasCercano;
            	}
        	}
			return planetaConveniente
		}
