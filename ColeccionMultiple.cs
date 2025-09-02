using System;

namespace MetodologiaTP
{
	//-Ejercicio 8-
	public class ColeccionMultiple : IColeccionable
	{
		private Pila pila;
		private Cola cola;
		
		
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
		
		public int cuantos(){
			int suma = pila.cuantos() + cola.cuantos();
			return suma;
		}
		
		public IComparable minimo(){
			if(pila.minimo().sosMenor(cola.minimo())) {
				return pila.minimo();
			}else {
				return cola.minimo();
			}
		}
		
		public IComparable maximo(){
			if(pila.maximo().sosMayor(cola.maximo())) {
				return pila.maximo();
			}else {
				return cola.maximo();
			}
		}
		
		public void agregar(IComparable c){
			//Vacío por enunciado
		}
		
		public bool contiene(IComparable c){
			if (pila.contiene(c) || cola.contiene(c)) {
				return true;
			}else {
				return false;
			}
		}
	}
}
