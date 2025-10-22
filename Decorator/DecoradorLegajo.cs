namespace MetodologiaTP
{
    public class DecoradorLegajo : AlumnoDecorator
    {
        public DecoradorLegajo(IAlumno a) : base(a)
        {
        }

        public override string mostrarCalificacion()
        {
            string nombre = getNombre();
            int legajo = Legajo;
            int nota = Calificacion;

            return $"{nombre} ({legajo}/6) {nota}";
        }
    }
}