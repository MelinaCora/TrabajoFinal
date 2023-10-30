
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
			int turnox= turno.ObtenerTurno();
			Planeta planetaActual = botPlaneta;
			//obtener camino desde el planetaIA hasta el destino y realizar el movimiento solo si existe un camino directo
			Planeta planetaObjetivo=planetaDestino.ObtenerPlanetaD()
			List<Planeta> caminox = ObtenerCamino(arbol, planetaObjetivo);
			while (turnox > 0 && camino != null && camino.Count > 1){
				// Avanzar al siguiente planeta en el camino
        			Planeta siguientePlaneta = camino[1];
				if (siguientePlaneta.EsPlanetadelJugador())
				{
					// Realizar interacción con el planeta objetivo (cálculo de flotas, eliminación, etc.)
            				int flotasBot = botPlaneta.ObtenerFlotas();
            				int flotasObjetivo = siguientePlaneta.ObtenerFlotas();
            				botPlaneta.AgregarFlotas(flotasObjetivo);
            				siguientePlaneta.DisminuirFlotas(flotasObjetivo);

            				// Actualizar el árbol de juego
           			 	arbol.EliminarHijo(siguientePlaneta);
			
				}
				// Mover la flota de naves al siguiente planeta
        			planetaActual.Flota = null;
        			siguientePlaneta.Flota = botPlaneta.Flota;
        			planetaActual = siguientePlaneta;

        			// Reducir el turno y actualizar el camino
        			turnox--;
        			camino.RemoveAt(0);
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
