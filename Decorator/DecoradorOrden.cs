namespace MetodologiaTP
{
    public class DecoradorOrden : AlumnoDecorator
    {
        private static int count = 0;
        public DecoradorOrden(IAlumno a) : base(a) { }
        
        public override string mostrarCalificacion()
        {
            count++;
            string texto = $"{count}) {base.mostrarCalificacion()}";

            return texto;
        }
    }
}