namespace MetodologiaTP
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override IComparable crearAleatorio()
        {
            return new Numero(generador.numeroAleatorio(50));
        }

        public override IComparable crearPorTeclado()
        {
            Console.Write("Ingrese un número: ");
            int numero = lector.numeroPorTeclado();

            return new Numero(numero);
            
        }
    }
}