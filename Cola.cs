using System;
using System.Linq;
using System.Collections.Generic;

namespace MetodologiaTP
{
	//-Ejercicio 4-
	public class Cola: IColeccionable
	{
		private List<IComparable> elementos;
		
		public Cola()
		{
			this.elementos = new List<IComparable>();
		}
		
		public void encolar(IComparable c){
			elementos.Add(c);
		}
		
		public IComparable desencolar(){
			IComparable aux = this.elementos[0];
			
			this.elementos.RemoveAt(0);
				
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
			this.encolar(c);
		}
		
		public bool contiene(IComparable c){
			int n = cuantos();
			for (int i = 0; i < n; i++) {
				if (this.elementos[i].sosIgual(c)) {
					return true;
				}
			}
			return false;
		}
	}
}
