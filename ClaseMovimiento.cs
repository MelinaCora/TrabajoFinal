
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

		public void RealizarMovimiento(List <Planeta> camino,Planeta planetaActual)
		{
			int turnox=ObtenerTurno();
						
			while (turnox > 0 && camino != null && camino.Count > 1){
				// Avanzar al siguiente planeta en el camino
        			Planeta siguientePlaneta = camino[1];
				if (siguientePlaneta.EsPlanetadelJugador())
				{
					if (siguientePlaneta.ObtenerFlota()<planetaActual.ObtenerFlota())){
						// Realizar interacción con el planeta objetivo
						planetaActual.AgregarNaves(siguientePlaneta.naves());
						siguientePlaneta.DisminuirNaves(siguientePlaneta.naves());
						siguientePlaneta.CambiarPropiedad("Azul");
					}
					if(siguientePlaneta.ObtenerFlota()>planetaActual.ObtenerFlota()){
						siguientePlaneta.AgregarNaves(planetaActual.naves());
						planetaActual.DisminuirNaves(siguientePlaneta.naves());
						planetaActual.CambiarPropiedad("Rojo");
					}
			
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
        			camino.RemoveAt(0);
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
