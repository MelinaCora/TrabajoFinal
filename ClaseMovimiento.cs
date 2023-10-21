
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

		public void RealizarMovimiento(Planeta botPlaneta,Planeta planetaObjetivo,ArbolGeneral<Planeta> arbolJugador)
		{
			int FlotasBot=botPlaneta.ObtenerFlotas();
			int FlotasObjetivo=planetaObjetivo.ObtenerFlotas();
			botPlaneta.AgregarFlotas(FlotasObjetivo);
			planetaObjetivo.DisminuirFlotas(FlotasObjetivo);
			arbolJugador.EliminarHijo(planetaObjetivo);
		}
		
	}
}	
