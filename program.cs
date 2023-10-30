using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	class Program
	{
		public static void Main(string[] args)
		{
			Flota FlotaIA=new Flota("Flota Bot",200,400);
            		Flota FlotaJugador=new Flota("Flota Jugador",200,400);
            		Flota FlotaNeutral=new Flota("Flota Neutral",200,400);
						
			// Crear planetas para la IA
            		Planeta planetaIA1 = new Planeta("Azul", "IA1", 1000, 300,FlotaIA);
            		Planeta planetaIA2 = new Planeta("Azul", "IA2", 1500, 220,FlotaIA);
            		Planeta planetaIA3 = new Planeta("Azul", "IA3", 1325, 300,FlotaIA);
            		Planeta planetaIA4 = new Planeta("Azul", "IA4", 1100, 500,FlotaIA);
            		Planeta planetaIA5 = new Planeta("Azul", "IA5", 990, 700,FlotaIA);
            		Planeta planetaIA6 = new Planeta("Azul", "IA6", 990, 700, FlotaIA);
				
				
            		// Crear planetas para el jugador
            		Planeta planetaJugador1 = new Planeta("Rojo", "Jugador1", 1200, 300,FlotaJugador);
            		Planeta planetaJugador2 = new Planeta("Rojo", "Jugador2", 1800, 220,FlotaJugador);
            		Planeta planetaJugador3 = new Planeta("Rojo", "Jugador3", 1000, 300,FlotaJugador);
            		Planeta planetaJugador4 = new Planeta("Rojo", "Jugador4", 1350, 500,FlotaJugador);
            		Planeta planetaJugador5 = new Planeta("Rojo", "Jugador5", 1440,700 ,FlotaJugador);
            		Planeta planetaJugador6 = new Planeta("Rojo", "Jugador6", 1800, 220,FlotaJugador);
           
            		// Crear planetas neutrales
            		Planeta planetaNeutral1 = new Planeta("Blanco", "Neutral1", 1000, 300,FlotaNeutral);
            		Planeta planetaNeutral2 = new Planeta("Blanco", "Neutral2", 1500, 220, FlotaNeutral);
            		Planeta planetaNeutral3 = new Planeta("Blanco", "Neutral3", 1325, 300, FlotaNeutral);
            		Planeta planetaNeutral4 = new Planeta("Blanco", "Neutral4", 1100, 500, FlotaNeutral);
            		Planeta planetaNeutral5 = new Planeta("Blanco", "Neutral5", 990, 700, FlotaNeutral);
            		Planeta planetaNeutral6 = new Planeta("Blanco", "Neutral6", 990, 700, FlotaNeutral);
            		
			//armo el arbol general
			
            		ArbolGeneral Arbol1= new ArbolGeneral();
            		Arbol1.AgregarHijo(planetaIA1); //raiz
            		//nivel 1
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaIA1,planetaIA5); 
           		Arbol1.AgregarHijoAunDeterminadoNodo(planetaIA1,planetaJugador1);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaIA1,planetaJugador3);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaIA1,planetaIA3);
            		//nivel 2
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaIA5,planetaJugador5);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaIA5,planetaNeutral1);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaJugador1,planetaJugador6);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaJugador1,planetaIA2);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaJugador1,planetaNeutral2);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaJugador3,planetaJugador4);
			Arbol1.AgregarHijoAunDeterminadoNodo(planetaIA3,planetaJugador2);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaIA3,planetaNeutral6);
            		//nivel 3
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaJugador5,planetaNeutral5);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaJugador5,planetaIA6);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaIA2,planetaNeutral4);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaJugador4,planetaNeutral3);
            		Arbol1.AgregarHijoAunDeterminadoNodo(planetaJugador4,planetaIA4);
            
            		//ciclo de juego
            		List <Planeta> CaminoConveniente=estrategia1.CalcularMoviemiento(Arbol1,planetaIA1,planetaIA4);
            		estrategia1.Consulta1(Arbol1,planetaIA1,Arbol1.Dato);
           	 	estrategia1.Consulta2(Arbol1,planetaIA1);
            		estrategia1.Consulta3(Arbol1);
               		Movimiento Juego1 = new Movimiento(planetaIA1,planetaIA4,Arbol1,FlotaIA);
            		Juego1.RealizarMovimiento(CaminoConveniente,planetaIA1);

			estrategia1.VerificarVictoria(Arbol1);
		}
	}
}

