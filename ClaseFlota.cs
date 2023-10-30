using System;

namespace TP_obligatorio
{
	
	public class Flota
	{
		//atributos
		private string NombreFlota;
		private int Velocidad;
		private int CantidadNaves;
		
		public Flota(string nombreFlota,int velocidad,int cantidadNaves)
		{
			NombreFlota=nombreFlota;
			Velocidad= velocidad;
			CantidadNaves= cantidadNaves;
		}

		public string ObtenerNombreFlota(){
			return NombreFlota;
		}
		public int ObtenerVelocidad(){
			return Velocidad;
		}
		public int ObtenerCantidadNaves(){
			return CantidadNaves;
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
