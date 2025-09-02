using System;

namespace MetodologiaTP
{
	//Ejercicio 11
	public abstract class Persona : IComparable
	{
		private string nombre;
		private int dni;
		
		public Persona(string n, int d)
		{
			this.nombre = n;
			this.dni = d;
		}
		
		//Encapsulamiento
		public string getNombre {
			get{return this.nombre;}
		}
		
		public int getDNI {
			get{return this.dni;}
		}
		
		public virtual bool sosIgual(IComparable c){
			if (this.dni == ((Persona)c).getDNI) {
				return true;
			}else {
				return false;
			}
		}
		
		public virtual bool sosMenor(IComparable c){
			if (this.dni < ((Persona)c).getDNI) {
				return true;
			}else {
				return false;
			}
		}
		
		public virtual bool sosMayor(IComparable c){
			if (this.dni > ((Persona)c).getDNI) {
				return true;
			}else {
				return false;
			}
		}
		
	}
}
