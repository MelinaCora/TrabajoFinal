using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	
	public class ArbolGeneral
		
		
	{
		// atributos
		private T dato {get; set;}
		private List <ArbolGeneral<T>> Hijos {get; set;}
		
		//constructor
		public ArbolGeneral(T dato)
		{
			Dato= dato;
			Hijos = new List <ArbolGeneral<T>> ();
		}
		
	}
}
