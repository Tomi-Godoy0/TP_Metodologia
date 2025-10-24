namespace MetodologiaTP
{
    public class FabricaDeAlumnosMuyEstudiosos : FabricaDeComparables
    {
        public override IComparable crearAleatorio()
        {
            string nombre = generador.stringAleatorio();
            int dni = generador.numeroAleatorio(50000000);
            int legajo = generador.numeroAleatorio(999999);
            int promedio = generador.numeroAleatorio(10);


            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
        }

        public override IComparable crearPorTeclado()
        {
            Console.WriteLine("Creando Alumno...\nIngrese los siguientes datos:");
            Console.Write("- Nombre: ");
            string nombre = lector.stringPorTeclado();
            Console.Write("- DNI: ");
            int dni = lector.numeroPorTeclado();
            Console.Write("- Legajo: ");
            int legajo = lector.numeroPorTeclado();
            Console.Write("- Promedio: ");
            int promedio = lector.numeroPorTeclado();

            return new AlumnoMuyEstudioso(nombre, dni, legajo, promedio);
        }
    }
}