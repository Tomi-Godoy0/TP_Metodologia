using System;

namespace MetodologiaTP
{
	class Program
	{
		public static void Main(string[] args)
		{
			// //Ejercicio 6
			// Pila p4 = new Pila();
			// Console.WriteLine("Seleccione que tipo de objeto deseas crear: ");
			// Console.WriteLine("1 - Números");
			// Console.WriteLine("2 - Alumnos");
			// //Ejercicio 9 
			// Console.WriteLine("3 - Profesor");
			// Console.WriteLine("----------------------------");

			// int opcion = int.Parse(Console.ReadLine());

			// Console.WriteLine("=================LLenando Colección=================");
			// Llenar(p4, opcion);
			// Console.WriteLine("Colección llena con 20 elementos.");
			// Informar(p4, opcion);

			// Console.WriteLine("\n================= PROGRAMA FINALIZADO =================");

			// //Ejercicio 14
			// GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();

			// Profesor p1 = new Profesor(gen.stringAleatorio(), gen.numeroAleatorio(40000000), gen.numeroAleatorio(25));

			// FabricaDeAlumnos fabricaAlu = new FabricaDeAlumnos(); //Creo la fabrica afuera para que se instancie solo una vez
			// List<Alumno> listAlum = new List<Alumno>();
			// for (int i = 0; i < 20; i++)
			// {
			// 	Alumno alu = (Alumno)fabricaAlu.crearAleatorio();
			// 	listAlum.Add(alu);
			// 	p1.agregarObservador(alu);
			// }

			// Console.WriteLine("-Los alumnos observan al profesor-");
			// dictadoDeClases(p1);

			//// Clase 4 - Ejercicio 4
            Student student;
            Teacher t1 = new Teacher();
            IAlumno alumno;

            FabricaDeAlumnos fabricaAlu = new FabricaDeAlumnos();
            for (int i = 0; i < 20; i++)
            {
                if (i < 10)
                {
                    alumno = (IAlumno)FabricaDeComparables.crearAleatorio(2);
                    // Clase 4 - Ejercicio 7 y 8
                    IAlumno decorado = new DecoradorLegajo(alumno);
                    decorado = new DecoradorLetras(decorado);
                    decorado = new DecoradorOrden(decorado);
                    decorado = new DecoradorPromocion(decorado);
                    decorado = new DecoradorAsteriscos(decorado);
                    student = new AlumnoAdapter(decorado);
                }
                else
                {
                    AlumnoMuyEstudioso alumnoEstudioso = (AlumnoMuyEstudioso)fabricaAlu.crearAleatorioEstudioso();

                    IAlumno decorado = new DecoradorLetras(alumnoEstudioso);
                    decorado = new DecoradorPromocion(decorado);
					decorado = new DecoradorAsteriscos(decorado);
					

                    student = new AlumnoAdapter(decorado);
                }
                t1.goToClass(student);
            }

            t1.teachingAClass();
		}

		private static Random rnd = new Random(); //Funciona mediante el reloj del sistema por lo cuál si lo pongo en "Llenar" utiliza los mismos números en pila y cola.
												  //En cambio poniendolo afuera lo que hace es inicializarse una sola vez y después sigue la secuencia.
												  //- Ejercicio 6 -
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

		//Ejercicio 13
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
