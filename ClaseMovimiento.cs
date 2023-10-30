
using System;
using System.Collections;

namespace TP_obligatorio
{
	
	public class Movimiento
	{
		//atributos
		private Planeta planetaOrigen {get; set;}
		private Planeta planetaDestino {get;set;}
		private int turno {get;set;}
		public Flota Flota {get; set;}
		
		//constructor
		public Movimiento(Planeta origen, Planeta destino, ArbolGeneral<Planeta> arbol, Flota flota)
		{
			Planeta origen=planetaOrigen;
			Planeta destino= planetaDestino;
			flota=Flota;
			
		}

		public void RealizarMovimiento(Planeta botPlaneta,Planeta planetaObjetivo,ArbolGeneral<Planeta> arbol)
		{
			int turnox=ObtenerTurno();
			Planeta planetaActual = botPlaneta;
			//obtener camino desde el planetaIA hasta el destino y realizar el movimiento solo si existe un camino directo
			
			List<Planeta> caminox =ObtenerCamino(arbol, planetaObjetivo);
			while (turnox > 0 && caminox != null && caminox.Count > 1){
				// Avanzar al siguiente planeta en el camino
        			Planeta siguientePlaneta = caminox[1];
				if (siguientePlaneta.EsPlanetadelJugador())
				{
					// Realizar interacción con el planeta objetivo 
					planetaActual+=siguientePlaneta.naves();
					siguientePlaneta.naves()=0;
					siguientePlaneta.ObtenerPropiedad()="Azul";
			
				}
				if (siguientePlaneta.EsPlanetadelaIA()){
					planetaActual.naves()+=siguientePlaneta.naves();
				}
				// Mover la flota de naves al siguiente planeta
				planetaActual.ObtenerFlota() = null;
				siguientePlaneta.ObtenerFlota() = botPlaneta.ObtenerFlota();
        			planetaActual = siguientePlaneta;

        		// Reducir el turno y actualizar el camino
        		turnox--;
        		caminox.RemoveAt(0);
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
