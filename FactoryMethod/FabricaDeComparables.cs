namespace MetodologiaTP
{
    //-Ejercicio 4 
    public abstract class FabricaDeComparables
    {
        // Métodos encargados de crear cada instancia. Lo voy a desarrollar en la fábrica concreta
        public abstract IComparable crearAleatorio();
        public abstract IComparable crearPorTeclado();
        
        // Al ponerlos como protected los van a poder usar las subclases.
        protected GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();
        protected LectorDeDatos lector = new LectorDeDatos();


        public static IComparable crearAleatorio(int opcion)
        {
            FabricaDeComparables fabrica = seleccionFabrica(opcion);

            if (fabrica == null)
            {
                Console.WriteLine("No se puede crear la fabrica. Seleccione una opción correcta 1 o 2");
                return null;
            }

            return fabrica.crearAleatorio();
        }

        public static IComparable crearPorTeclado(int opcion)
        {
            FabricaDeComparables fabrica = seleccionFabrica(opcion);

            if (fabrica == null)
            {
                Console.WriteLine("No se puede crear la fabrica. Seleccione una opción correcta 1 o 2");
                return null;
            }

            return fabrica.crearPorTeclado();
        }
        
        public static FabricaDeComparables seleccionFabrica(int opcion)
        {
            switch (opcion)
            {
                case 1: return new FabricaDeNumeros();
                case 2: return new FabricaDeAlumnos();
                case 3: return new FabricaDeProfesor();
                case 4: return new FabricaDeAlumnosMuyEstudiosos();
                default: return null;
            }
        }
    }
}