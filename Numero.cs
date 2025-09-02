using System;

namespace MetodologiaTP
{
	//-Ejercicio 2-
	public class Numero : IComparable
	{
		private int valor;
		
		public Numero(int v)
		{
			this.valor = v;
		}
		
		public int getValor {
			get {return this.valor;}
		}
		//Parte del ejercicio 6
		public override string ToString()
		{
			return valor.ToString();
		}
		
		public bool sosIgual(IComparable c){
			return this.valor == ((Numero)c).getValor;
		}
		
		public bool sosMenor(IComparable c){
			if (this.valor < ((Numero)c).getValor) {
				return true;
			}else {
				return false;
			}
		}
		
		public bool sosMayor(IComparable c){
			if (this.valor > ((Numero)c).getValor) {
				return true;
			}else {
				return false;
			}
		}
		
	}
}
