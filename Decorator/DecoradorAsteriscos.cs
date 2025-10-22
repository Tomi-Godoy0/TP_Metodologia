namespace MetodologiaTP
{
    public class DecoradorAsteriscos : AlumnoDecorator
    {
        public DecoradorAsteriscos(IAlumno a) : base(a) { }
        
        public override string mostrarCalificacion()
        {
            string texto = base.mostrarCalificacion();

            string asteriscos = "*" + new string('*', texto.Length + 3);

            return $"{asteriscos}\n* {texto} *\n{asteriscos}";
        }                                                
    }
}