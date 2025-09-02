using System;

namespace MetodologiaTP
{	
	public interface IComparable
	{
		//-Ejercicio 1-
		bool sosIgual(IComparable c);
		bool sosMenor(IComparable c);
		bool sosMayor(IComparable c);
	}
}
