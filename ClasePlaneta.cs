using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	
	public class Planeta
	{
		//atributos
		private string Propiedad{get;set;}
		private string Nombre{get;set;}
		private int Poblacion {get;set;}
		private int Flotas{get;set;}
		private int TasaCrecimiento{get;set;}
		private List<Planeta> Hijos { get; set; }
		
		//constructor
		public Planeta(string propiedad,string nombre,int poblacion,int flotas,int tasaCrecimiento)
		{
			this.Propiedad=propiedad;
			this.Nombre=nombre;
			this.Poblacion=poblacion;
			this.Flotas=flotas;
			this.TasaCrecimiento=tasaCrecimiento;
			Hijos = new List<Planeta>();
			
		}
		
		
		//metodo para hallar el planeta mas cercano
		private Planeta PlanetaMasCercano(ArbolGeneral <Planeta> arbol,Planeta o,Planeta d)
      
			//Recorrer el arbol  desde un nodo hasta otro comparano si el planeta d tiene menos flotas que el o 
	   	{
        	
			Planeta planetaMasCercano = o;
			Planeta planetaConveniente= null;
			
			if (Hijos != null) //la lista de hijos debe ser distinta de nula
			{
        		foreach (var hijo in Hijos)
        		{
            	            	
        			  // Llamar recursivamente a la función para cada hijo
            		Planeta planetaHijoMasCercano = PlanetaMasCercano(arbol,hijo,d);

            		// Comparar el número de naves del planeta más cercano actual con el del hijo
            		if (planetaHijoMasCercano != null && planetaHijoMasCercano.Flotas < planetaMasCercano.Flotas)
            		{
                		planetaConveniente = planetaHijoMasCercano;
            		}
            	
        		}
			
			}
			
			return planetaConveniente;
		}
			
		//metodos para agregar la propiedad del planeta
		public bool EsPlanetadelaIA(string Propiedad)
		{
			return Propiedad.Equals("Azul", StringComparison.OrdinalIgnoreCase);
		}
		
		public bool EsPlanetadelJugador(string Propiedad)
		{
			return Propiedad.Equals("Rojo", StringComparison.OrdinalIgnoreCase);
		}
		
		public bool EsPlanetaNeutral(string Propiedad)
		{
			return Propiedad.Equals("Blanco", StringComparison.OrdinalIgnoreCase);
		}
	}
}
