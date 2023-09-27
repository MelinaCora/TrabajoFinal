using System;
using System.Collections.Generic;
namespace TP_obligatorio
{
	
	public class Estrategia
	{
		//atributos
		private Planeta botPlaneta;
		
		
		//constructor
		public Estrategia(Planeta botPlaneta)
		{
			BotPlaneta=botPlaneta;
		}
		
		//metodos
		public string CalcularMoviemiento (ArbolGeneral<Planeta> arbol, Planeta BotPlaneta)//cuerpo de la estrategia
		{
			//calcular descendientes del planeta raiz del jugador
			//a partir de esa lista calcular que planeta me conviene atacar
			//realizar el moviemiento, ese planeta pasa a ser del bot y se suman las flotas
			//necesito reaizar una operacion en caso de que el jugador elimine un planeta bot, entonces debe cambiar mi raiz a algun hijo
					
		}
		
		public string Consulta1()//usar calcular distancia
		{
		}
		
		public string Consulta2()//usar ObtenerDescendientes
		{
		}
		
		public string Consulta3()
		{
		}
		
		private List<string> ObtenerDescendientes() //devuelve una lista con los hijos de determinado planeta
		{
		}
		
		private int CalcularDistancia()//calcular la distancia entre dos planetas
		{
		}
		
	}
}
