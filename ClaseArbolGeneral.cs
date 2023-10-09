using System;
using System.Collections.Generic;

namespace TP_obligatorio
{
	public class ArbolGeneral<T>
   	 {
        	// Atributos
        	private T Dato { get; set; }
        	private List<Planeta> Hijos { get; set; }

        	// Constructor
        	public ArbolGeneral(T dato, List<Planeta> hijos)
        	{
            		Dato = dato;
    			Hijos = new List<Planeta>();
        	}
	 
     		private void RecorridoPreorden()
		{
    	    		if (nodo != null)
    			{
        			lista.Add(nodo);  // Agregar el nodo actual a la lista
        			var planetasArecorrer=arbol.getHijos(nodo);
        			foreach (var hijo in planetasArecorrer)
        			{
            				RecorridoPreorden();  // Recorrer cada hijo en preorden
        			}
    			}
        	}
 		//metodo de agregar hijo
		public void AgregarHijo(Planeta planeta)
		{
			Hijos.Add(planeta);
		}

  		public void AgregarHijoAunDeterminadoNodo(Planeta padre, Planeta planetaAgregar)
		{
			var nodoPadre = Hijos.FirstOrDefault(nodo => nodo == padre);
			if (nodoPadre != null)
    		{
       	 		nodoPadre.Hijos.Add(hijo);
			}
		}
		
  		//metodo para obtener los hijos de un nodo
		public List<Planeta> getHijos(Planeta planeta)
		{
			return Hijos;
		}

   		public void EliminarHijo(Planeta planeta)
     		{
       			Hijos.Remove(planeta);
		}
}
