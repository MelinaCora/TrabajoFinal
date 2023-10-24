
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
		public Movimiento(Planeta origen, Planeta destino, ArbolGeneral<Planeta> arbol)
		{
			Planeta origen=planetaOrigen;
			Planeta destino= planetaDestino;
			
		}

		public void RealizarMovimiento(Planeta botPlaneta,Planeta planetaObjetivo,ArbolGeneral<Planeta> arbol)
		{
			int turno=100;
			//obtener camino desde el planetaIA hasta el destino y realizar el movimiento solo si existe un camino directo
			Planeta planetaObjetivo=planetaDestino.ObtenerPlanetaD()
			List<Planeta> caminox = ObtenerCamino(arbol, planetaObjetivo);
			if (caminox != null)
			{
				//recorro cada nodo del camino obtenido y evaluo si es del jugador. en casos contrarios solo avanzo y disminuyo el turno			
				foreach (Planeta nodo in caminox){
					if (nodo.EsPlanetadelJugador()){
						int FlotasBot=botPlaneta.ObtenerFlotas();
						int FlotasObjetivo=planetaObjetivo.ObtenerFlotas();
						botPlaneta.AgregarFlotas(FlotasObjetivo);
						planetaObjetivo.DisminuirFlotas(FlotasObjetivo);
						arbolJugador.EliminarHijo(planetaObjetivo);
					}else{
						turno--;
					}
				}
			
			}
		}
		
		public Planeta ObtenerPlanetaD()
		{
			return planetaDestino;
		}
		public Planeta ObtenerPlanetaO()
		{
			return planetaOrigen;
		}
		
	}
}	
