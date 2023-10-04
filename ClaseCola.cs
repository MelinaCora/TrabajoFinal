using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	public class Cola<T>
	{
		//Atributo
		private Queue<T> queue;
		
		//constructor
		public Cola()
		{
			queue = new Queue<T>();
		}
		
		//metodos
		public void Encolar(T item)
    	{
        	queue.Encolar(item);
    	}

    	public T Desencolar()
    	{
        	if (queue.Count == 0)
        	{
            	throw new InvalidOperationException("La cola está vacía.");
        	}
        	return queue.Desencolar();
    	}

    	public int Contar()
    	{
        	return queue.Count;
    	}

    	public bool EstaVacia()
    	{
        	return queue.Count == 0;
    	}
	}
}
