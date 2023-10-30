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
			
            		ArbolGeneral <Planeta> Arbol1= new ArbolGeneral();
            		ArbolGeneral<Planeta> hijoPlaneta = new ArbolGeneral<Planeta>();
			hijoPlaneta.Dato = planetaIA1; // Establecer el planeta como dato del hijo
			Arbol1.AgregarHijo(hijoPlaneta); // Agregar el hijo al árbol principal
			ArbolGeneral<Planeta> hijoPlaneta2 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlaneta3 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlaneta4 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlaneta5 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlaneta6 = new ArbolGeneral<Planeta>();
            		hijoPlaneta2.Dato = planetaIA2;
            		hijoPlaneta3.Dato = planetaIA3;
            		hijoPlaneta4.Dato = planetaIA4;
            		hijoPlaneta5.Dato = planetaIA5;
            		hijoPlaneta6.Dato = planetaIA6;
            		ArbolGeneral<Planeta> hijoPlanetaJ1 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaJ2 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaJ3 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaJ4 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaJ5 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaJ6 = new ArbolGeneral<Planeta>();
            		hijoPlanetaJ1.Dato = planetaJugador1;
            		hijoPlanetaJ2.Dato = planetaJugador2;
            		hijoPlanetaJ3.Dato = planetaJugador3;
            		hijoPlanetaJ4.Dato = planetaJugador4;
            		hijoPlanetaJ5.Dato = planetaJugador5;
            		hijoPlanetaJ6.Dato = planetaJugador6;
            		ArbolGeneral<Planeta> hijoPlanetaN1 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaN2 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaN3 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaN4 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaN5 = new ArbolGeneral<Planeta>();
            		ArbolGeneral<Planeta> hijoPlanetaN6 = new ArbolGeneral<Planeta>();
            		hijoPlanetaN1.Dato = planetaNeutral1;
            		hijoPlanetaN2.Dato = planetaNeutral2;
            		hijoPlanetaN3.Dato = planetaNeutral3;
            		hijoPlanetaN4.Dato = planetaNeutral4;
            		hijoPlanetaN5.Dato = planetaNeutral5;
            		hijoPlanetaN6.Dato = planetaNeutral6;
            		//nivel 1
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlaneta,hijoPlaneta5); 
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlaneta,hijoPlanetaJ1);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlaneta,hijoPlanetaJ3);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlaneta,hijoPlaneta3);
            		//nivel 2
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlaneta5,hijoPlanetaJ5);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlaneta5,hijoPlanetaN1);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlanetaJ1,hijoPlanetaJ6);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlanetaJ1,hijoPlaneta2);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlanetaJ1,hijoPlanetaN2);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlanetaJ3,hijoPlanetaJ4);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlaneta3,hijoPlanetaJ2);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlaneta3,hijoPlanetaN6);
            		//nivel 3
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlanetaJ5,hijoPlanetaN5);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlanetaJ5,hijoPlaneta6);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlaneta2,hijoPlanetaN4);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlanetaJ4,hijoPlanetaN3);
            		Arbol1.AgregarHijoAunDeterminadoNodo(hijoPlanetaJ4,hijoPlaneta4);
            
            		//ciclo de juego
            		List <Planeta> CaminoConveniente=estrategia1.CalcularMoviemiento(Arbol1,planetaIA1,planetaIA4);
            		estrategia1.Consulta1(Arbol1,planetaIA1,Arbol1.Dato);
           	 	estrategia1.Consulta2(Arbol1,planetaIA1);
            		estrategia1.Consulta3(Arbol1);
               		Movimiento Juego1 = new Movimiento(planetaIA1,planetaIA4,Arbol1,FlotaIA,4);
            		Juego1.RealizarMovimiento(CaminoConveniente,planetaIA1);

			estrategia1.VerificarVictoria(Arbol1);
		}
	}
}

