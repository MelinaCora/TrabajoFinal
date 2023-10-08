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
            	            		Planeta planetaHijoMasCercano = PlanetaMasCercano(arbol,hijo,d);
					// Comparar el número de flotas del planeta más cercano actual con el del hijo
            				if (planetaHijoMasCercano != null && planetaHijoMasCercano.Flotas < planetaMasCercano.Flotas)
            				{
                				planetaConveniente = planetaHijoMasCercano;
            				}
            	
        			}
			
			}
			
			return planetaConveniente;
		}
			
		//metodos para verificar la propiedad del planeta
		public bool EsPlanetadelaIA()
		{
			return Propiedad.Equals("Azul", StringComparison.OrdinalIgnoreCase);
		}
		
		public bool EsPlanetadelJugador()
		{
			return Propiedad.Equals("Rojo", StringComparison.OrdinalIgnoreCase);
		}
		
		public bool EsPlanetaNeutral()
		{
			return Propiedad.Equals("Blanco", StringComparison.OrdinalIgnoreCase);
		}

		//metodo para agregar flotas a los planetas
		public void AgregarFlotas(int FlotasParaAgregar) 
		{
			Flotas+=FlotasParaAgregar;
		}

		//metodo para disminuir flotas
		public void DisminuirFlotas(int FlotasParaDisminuir)
		{
			Flotas-=FlotasParaDisminuir;
		}
		public string ObtenerNombre()
    		{
        		return Nombre;
    		}

    		// Método público para obtener la propiedad del planeta
    		public int ObtenerPoblacion()
    		{
        		return Poblacion;
    		}
	}
}
