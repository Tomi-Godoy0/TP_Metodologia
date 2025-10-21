namespace MetodologiaTP
{
    public class FabricaDeProfesor : FabricaDeComparables
    {
        public override IComparable crearAleatorio()
        {

            string nombre = generador.stringAleatorio();
            int dni = generador.numeroAleatorio(50000000);
            int antiguedad = generador.numeroAleatorio(25);

            return new Profesor(nombre, dni, antiguedad);
        }

        public override IComparable crearPorTeclado()
        {
            Console.WriteLine("Creando Profesor...");
            Console.Write("Nombre: ");
            string nombre = lector.stringPorTeclado();
            Console.Write("DNI: ");
            int dni = lector.numeroPorTeclado();
            Console.Write("Antiguedad: ");
            int antiguedad = lector.numeroPorTeclado();

            return new Profesor(nombre, dni, antiguedad);
        }
    }
}