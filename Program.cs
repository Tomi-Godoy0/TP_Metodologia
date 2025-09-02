using System;

namespace MetodologiaTP
{
	class Program
	{
		public static void Main(string[] args)
		{
			//-Ejercicio 7-
			Console.WriteLine("*-------------------Ejercicio 7----------------------*");
			
			Pila p = new Pila();
			Cola c = new Cola();
			Llenar(p);
			Informar(p);
			Console.WriteLine("*----------------------------------------------------*");
			Llenar(c);
			Informar(c);
			
			//-Ejercicio 9-
			Console.WriteLine("*-------------------Ejercicio 9----------------------*");
			Pila p1 = new Pila();
			Cola c1 = new Cola();
			ColeccionMultiple multiple = new ColeccionMultiple(p1, c1);
			Llenar(p1);
			Llenar(c1);
			Console.WriteLine("*--------------------------Pila----------------------*");
			Informar(p1);
			Console.WriteLine("*--------------------------Cola----------------------*");
			Informar(c1);
			Console.WriteLine("*--------------------------Multiple------------------*");
			Informar(multiple);
			
			//-Ejercicio 14-
			Console.WriteLine("*-------------------Ejercicio 14----------------------*");
			Pila pAlum = new Pila();
			Cola cAlum = new Cola();
			ColeccionMultiple multipleAlum = new ColeccionMultiple(pAlum, cAlum);
			
			LlenarAlumnos(pAlum);
			LlenarAlumnos(cAlum);
			Informar(multipleAlum);
		
			Console.ReadKey(true);
		}
		//-Ejercicio 5-
		private static 	Random rnd = new Random(); //Funciona mediante el reloj del sistema por lo cuál si lo pongo en "Llenar" utiliza los mismos números en pila y cola.
												  //En cambio poniendolo afuera lo que hace es inicializarse una sola vez y después sigue la secuncia.
		//-Ejercicio 5-
		public static void Llenar(IColeccionable col){
			for(int i = 0; i < 20; i++){
				int valor = rnd.Next(1,90);
				
				col.agregar(new Numero(valor));
			}
		}
		//-Ejercicio 13-
		public static void LlenarAlumnos(IColeccionable col){
			IComparable[] alumnos = {
			    new Alumno("Tomas", 44722840, 77142, 1),
			    new Alumno("Lucia", 45100231, 1, 10),
			    new Alumno("Juan", 45211894, 77144, 9),
			    new Alumno("Ana", 45376543, 77145, 7),
			    new Alumno("Marcos", 45498212, 77146, 5),
			    new Alumno("Valentina", 45622134, 77147, 10),
			    new Alumno("Sofia", 45711222, 77148, 4),
			    new Alumno("Mateo", 45800321, 77149, 3),
			    new Alumno("Camila", 45988877, 77150, 7),
			    new Alumno("Agustin", 46011223, 77151, 6),
			    new Alumno("Martina", 46129384, 77152, 9),
			    new Alumno("Pedro", 46277412, 77153, 2),
			    new Alumno("Julieta", 46300456, 77154, 8),
			    new Alumno("Nicolas", 46400321, 77155, 5),
			    new Alumno("Carla", 46588221, 77156, 7),
			    new Alumno("Franco", 46633219, 77157, 4),
			    new Alumno("Victoria", 46722100, 77158, 6),
			    new Alumno("Diego", 46877890, 77159, 9),
			    new Alumno("Paula", 46912211, 77160, 8),
			    new Alumno("Gonzalo", 47088765, 77161, 10)
			};
			
			foreach(IComparable alum in alumnos){		
				col.agregar(alum);
		  	}
		}								  
		//Ejericicio 6 - Me encontre con el primer problema: En la consola aparecia el objeto (nombre de la clase) no el número.
		//Lo resolví trabajando con un override ToString() en la clase Numero. Esto permite que al transformar el objeto en texto nos muestra lo que hay dentro del mismo en lugar del nombre de la clase.
		public static void Informar(IColeccionable col){
				Console.WriteLine("Cantidad: " + col.cuantos());
				Console.WriteLine("Minimo: " + col.minimo());
				Console.WriteLine("Máximo: " + col.maximo());
				
				if (col.minimo().GetType() == typeof(Numero)) {
					Console.Write("¿Qué elemento esta buscando en la colección?: ");
				
					IComparable nuevoNum = new Numero(int.Parse(Console.ReadLine()));
				
					if (col.contiene(nuevoNum)) {
						Console.WriteLine("El elemento leído está en la colección");
					}else {
						Console.WriteLine("El elemento leído NO está en la colección");
					}
				}
		}
	}
}