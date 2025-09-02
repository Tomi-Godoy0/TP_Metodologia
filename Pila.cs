using System;
using System.Linq;
using System.Collections.Generic;

namespace MetodologiaTP
{
	//-Ejercicio 4-
	public class Pila : IColeccionable
	{
		private List<IComparable> elementos;
			
		public Pila()
		{
			this.elementos = new List<IComparable>();
		}
		
		public void apilar(IComparable c){
			this.elementos.Add(c);			
		}
		
		public IComparable desapilar(){
			IComparable aux = elementos[this.elementos.Count - 1];
			this.elementos.RemoveAt(this.elementos.Count - 1);
			return aux;
		}
		
		//Implementar la interface Coleccionable
		public int cuantos(){
			return this.elementos.Count;
		}
		
		public IComparable minimo(){
			IComparable minimoActual = this.elementos[0];
			int n = cuantos();
			
			for (int i = 1; i < n; i++) {
				if (this.elementos[i].sosMenor(minimoActual)) {
					minimoActual = elementos[i];
				}
			}
			return minimoActual;
		}
		
		public IComparable maximo(){
			IComparable maximoActual = this.elementos[0];
			int n = cuantos();
			
			for (int i = 1; i < n; i++) {
				if (this.elementos[i].sosMayor(maximoActual)) {
					maximoActual = elementos[i];
				}
			}
			return maximoActual;
		}
		
		public void agregar(IComparable c){
			this.apilar(c);
		}
		
		public bool contiene(IComparable c){
			foreach (IComparable e in elementos) {
				if (e.sosIgual(c)) {
					return true;
				}
			}
			return false;
		}
	}
}
