using System;

namespace MetodologiaTP
{
	//Ejercicio 12
	public class Alumno : Persona
	{
		private int legajo;
		private int promedio;
		
		public Alumno(string n, int d, int l, int p) : base(n, d)
		{
			this.legajo = l;
			this.promedio = p;
		}
		
		public int getLegajo {
			get {return this.legajo;}
		}
		
		public int getPromedio {
			get {return this.promedio;}
		}
		
		public override string ToString()
		{
			return string.Format("Nombre: {0}, DNI: {1}, Legajo: {2}, Promedio: {3}", this.getNombre, this.getDNI , this.legajo, this.promedio);
		}
		//-Ejercicio 15- Comparable por legajo
		public override bool sosIgual(IComparable c){
			if (this.legajo == ((Alumno)c).getLegajo) {
				return true;
			}else {
				return false;
			}
		}
		
		public override bool sosMenor(IComparable c){
			if (this.legajo < ((Alumno)c).getLegajo) {
				return true;
			}else {
				return false;
			}
		}
		
		public override bool sosMayor(IComparable c){
			if (this.legajo > ((Alumno)c).getLegajo) {
				return true;
			}else {
				return false;
			}
		}
		
		//Comparable por promedio
//		public override bool sosIgual(IComparable c){
//			if (this.promedio < ((Alumno)c).getPromedio) {
//				return true;
//			}else {
//				return false;
//			}
//		}
//		
//		public override bool sosMenor(IComparable c){
//			if (this.promedio < ((Alumno)c).getPromedio) {
//				return true;
//			}else {
//				return false;
//			}
//		}
//		
//		public override bool sosMayor(IComparable c){
//			if (this.promedio > ((Alumno)c).getPromedio) {
//				return true;
//			}else {
//				return false;
//			}
//		}
	}
}
