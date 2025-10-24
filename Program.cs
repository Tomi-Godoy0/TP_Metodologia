using System;

namespace MetodologiaTP
{
	class Program
	{
		public static void Main(string[] args)
		{
            // Student student;
            // Teacher t1 = new Teacher();
            // IAlumno alumno;

            // // FabricaDeAlumnos fabricaAlu = new FabricaDeAlumnos();
            // for (int i = 0; i < 20; i++)
            // {
            //     if (i < 10)
            //     {
			// 		alumno = (IAlumno)FabricaDeComparables.crearAleatorio(2);
            // 		//Clase 5 - Ejercicio 2
			// 		alumno = new AlumnoProxy(new GeneradorDeDatosAleatorios().stringAleatorio(6), 2);
					
            //         IAlumno decorado = new DecoradorLegajo(alumno);
            //         decorado = new DecoradorLetras(decorado);
            //         decorado = new DecoradorOrden(decorado);
            //         decorado = new DecoradorPromocion(decorado);
            //         decorado = new DecoradorAsteriscos(decorado);
            //         student = new AlumnoAdapter(decorado);
            //     }
            //     else
			// 	{
            //         // AlumnoMuyEstudioso alumnoEstudioso = (AlumnoMuyEstudioso)fabricaAlu.crearAleatorioEstudioso();
			// 		//Crea alumno muy estudiosos
            // 		alumno = new AlumnoProxy(new GeneradorDeDatosAleatorios().stringAleatorio(6), 4);

            //         IAlumno decorado = new DecoradorLetras(alumno);
            //         decorado = new DecoradorPromocion(decorado);
			// 		decorado = new DecoradorAsteriscos(decorado);
					

            //         student = new AlumnoAdapter(decorado);
            //     }
            //     t1.goToClass(student);
            // }
            // t1.teachingAClass();

            // Clase 5 - Ejercicio 10
            // Prueba pila
            Aula aula = new Aula();
            Pila pila = new Pila();

			Console.WriteLine("Prueba Pila");
			pila.setOrdenInicio(new OrdenInicio(aula));
            pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));
            
            Llenar(pila, 2);
            Llenar(pila, 4);

            // Prueba cola
            Aula aula1 = new Aula();
			Cola cola = new Cola();

			Console.WriteLine("Prueba Cola");
            cola.setOrdenInicio(new OrdenInicio(aula1));
            cola.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula1));
            cola.setOrdenAulaLlena(new OrdenAulaLlena(aula1));

            Llenar(cola, 2);
            Llenar(cola, 4);			
		}

		private static Random rnd = new Random(); //Funciona mediante el reloj del sistema por lo cuál si lo pongo en "Llenar" utiliza los mismos números en pila y cola.
												  //En cambio poniendolo afuera lo que hace es inicializarse una sola vez y después sigue la secuencia.
												  
		public static void Llenar(IColeccionable col, int opcion)
		{
			for (int i = 0; i < 20; i++)
			{
				//Crea un nuevo Comparable Alumno o Número según la opción que elija
				IComparable comparable = FabricaDeComparables.crearAleatorio(opcion);
				//Se agrega a la coleccion
				if (comparable != null)
				{
					col.Agregar(comparable);
				}
			}
		}

		public static void Informar(IColeccionable col, int opcion)
		{
			Console.WriteLine("\n================= Informe =================");
			Console.WriteLine("Cantidad: " + col.Cuantos());
			Console.WriteLine("Min: " + col.Minimo());
			Console.WriteLine("Max: " + col.Maximo());

			//Crea un nuevo Comparable Alumno o Número según la opción que elija
			IComparable comparable = FabricaDeComparables.crearPorTeclado(opcion);
			if (comparable == null)
			{
				Console.WriteLine("No se pudo crear el elemento para comparar (opción inválida).");
				return;
			}
			//Se fija si esta en la colección
			Console.WriteLine("\n================= Comparación =================");
			if (col.Contiene(comparable))
			{
				Console.WriteLine("El elemento leído está en la colección");
			}
			else
			{
				Console.WriteLine("El elemento leído NO está en la colección");
			}

			Console.WriteLine("-----------------------------------------------------\n");
		}

		public static void dictadoDeClases(Profesor p)
		{
			for (int i = 0; i < 5; i++)
			{
				p.hablarALaClase();
				p.escribirEnElPizarron();
			}
		}

		public static void ImprimirElementos(IIterable col)
		{
			IIterador ite = col.CrearIterador();
			ite.Primero();

			while (!ite.Fin())
			{
				IComparable elem = ite.Actual();
				Console.WriteLine(elem);
				ite.Siguiente();
			}
		}

		public static void CambiarEstrategia(IColeccionable c, IEstrategiaComparacion e)
		{
			IIterable coleccion = (IIterable)c;
			IIterador it = coleccion.CrearIterador();
			if (coleccion == null || c.Cuantos() == 0)
			{
				Console.WriteLine("Esta vacia");
				return;
			}

			it.Primero();
			while (!it.Fin())
			{
				((Alumno)it.Actual()).SetEstrategia(e);
				it.Siguiente();
			}
		}
	}
}
