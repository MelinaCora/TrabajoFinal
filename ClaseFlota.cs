using System;

namespace TP_obligatorio
{
	
	public class Flota
	{
		//atributos
		private string nombreFlota;
		private int velocidad;
		private int cantidadNaves;
		
		public Flota(string NombreFlota,int Velocidad,int CantidadNaves)
		{
			NombreFlota=nombreFlota;
			Velocidad= velocidad;
			CantidadNaves= cantidadNaves;
		}

		public string ObtenerNombreFlota(){
			return nombreFlota;
		}
		public int ObtenerVelocidad(){
			return velocidad;
		}
		public int ObtenerCantidadNaves(){
			return cantidadNaves;
		}
		

		public void AgregarFlotas(int FlotasParaAgregar) 
		{
			Flotas+=FlotasParaAgregar;
		}
		
		public void DisminuirFlotas(int FlotasParaDisminuir)
		{
			Flotas-=FlotasParaDisminuir;
		}
	}
}
