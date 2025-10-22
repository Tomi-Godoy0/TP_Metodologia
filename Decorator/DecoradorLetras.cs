namespace MetodologiaTP
{
    public class DecoradorLetras : AlumnoDecorator
    {
        public DecoradorLetras(IAlumno a) : base(a) { }
        
        public override string mostrarCalificacion()
        {
            int nota = Calificacion;
            string texto = base.mostrarCalificacion();
            string notaEnLetra = "SIN NOTA";

            string[] listaDeNotas = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ" };

            if (nota >= 0 && nota <= 10)
            {
                notaEnLetra = listaDeNotas[nota];
            }

            return $"{texto} ({notaEnLetra})";
        }
    }
}