
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
			
			//primero realizo la busqueda del camino desde la IA hasta la raiz			
			List<Planeta> caminox =ObtenerCamino(arbol, botPlaneta);			
			// otra lista para el camino del destino hasta la raiz			
			List<Planeta> caminoy = ObtenerCamino(arbol, planetaObjetivo);
			//combinamos las listas para generar un solo camino			
			List<Planeta> caminoz = new List<Planeta>(caminox);
			caminoz.AddRange(caminoy);			
			//obtengo las posiciones de ambos en el camino			
			int indiceBot = caminoz.IndexOf(botPlaneta);
			int indiceObjetivo = caminoz.IndexOf(planetaObjetivo);
			//defino el nuevo camino desde el bot hasta 
			List<Planeta> caminoFinal = caminoz.GetRange(indiceBot, indiceObjetivo - indiceBot + 1);
						
			while (turnox > 0 && caminoFinal != null && caminoFinal.Count > 1){
				// Avanzar al siguiente planeta en el camino
        			Planeta siguientePlaneta = caminoFinal[1];
				if (siguientePlaneta.EsPlanetadelJugador())
				{
					// Realizar interacción con el planeta objetivo 
					planetaActual.AgregarNaves(siguientePlaneta.naves());
					siguientePlaneta.naves()=0;
					siguientePlaneta.ObtenerPropiedad()="Azul";
			
				}
				if (siguientePlaneta.EsPlanetadelaIA()){
					planetaActual.AgregarNaves(siguientePlaneta.naves());
				}
				// Mover la flota de naves al siguiente planeta
				planetaActual.ObtenerFlota() = null;
				siguientePlaneta.ObtenerFlota() = Flota;
        			planetaActual = siguientePlaneta;

        			// Reducir el turno y actualizar el camino
        			turnox--;
        			caminoFinal.RemoveAt(0);
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
		public List<Planeta> ObtenerCamino(ArbolGeneral<Planeta> arbol, Planeta planeta)
		{
    			List<Planeta> camino = new List<Planeta>();

    			Planeta nodoActual = planeta;

    			while (nodoActual != null)
    			{
        			camino.Add(nodoActual);
        			if (nodoActual.Equals(arbol.Dato))
            			break; // se corta una vez encontrada la raiz
    			}

    			camino.Reverse(); // Invertimos 
    			return camino;
			}
		
		}
}	
