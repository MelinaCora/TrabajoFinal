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
		private Flota Flota{get;set;}
		private int TasaCrecimiento{get;set;}
		private List<Planeta> Hijos { get; set; }
		
		//constructor
		public Planeta(string propiedad,string nombre,int poblacion,int tasaCrecimiento, Flota flota)
		{
			this.Propiedad=propiedad;
			this.Nombre=nombre;
			this.Poblacion=poblacion;
			Flota=flota;
			this.TasaCrecimiento=tasaCrecimiento;
			Hijos = new List<Planeta>();
			
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

		public string ObtenerNombre()
    		{
        		return Nombre;
    		}

    		// Método público para obtener la propiedad del planeta
    		public int ObtenerPoblacion()
    		{
        		return Poblacion;
    		}
		public string ObtenerPropiedad(){
    			return Propiedad;
    		}
    		public int naves(){
    			int totalnaves=Flota.ObtenerCantidadNaves();
    			return totalnaves;
    		}
		public void AgregarNaves(int NavesParaAgregar) 
		{
    			int cantidadNaves = Flota.ObtenerCantidadNaves();
    			cantidadNaves+=NavesParaAgregar;
		}
		
		public void DisminuirNaves(int NavesParaDisminuir)
		{
			int cantidadNaves = Flota.ObtenerCantidadNaves();
    			cantidadNaves-=NavesParaDisminuir;
		}
	}
}
