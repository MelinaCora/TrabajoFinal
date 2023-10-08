using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	public class Cola<T>
	{
		//Atributo
		private Cola<T> queue;
		
		//constructor
		public Cola()
		{
			queue = new Cola<T>();
		}
		
		//metodos
		public void Encolar(T item)
    		{
        		queue.Encolar(item);
    		}

    		public T Desencolar()
    		{
    			if (queue.Contar() == 0)
        		{
            			Console.Writeline("La cola esta vacía");
        		}
        		return queue.Desencolar();
    		}

    		public int Contar()
    		{
        		return queue.Contar();
    		}

    		public bool EstaVacia()
    		{
    			return queue.Contar() == 0;
    		}
	}
}
