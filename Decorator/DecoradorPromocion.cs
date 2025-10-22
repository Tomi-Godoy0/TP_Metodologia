namespace MetodologiaTP
{
    public class DecoradorPromocion : AlumnoDecorator
    {
        public DecoradorPromocion(IAlumno a) : base(a) { }
        
        public override string mostrarCalificacion()
        {
            int nota = Calificacion;
            string estado;
            string texto = base.mostrarCalificacion();

            if (nota >= 7)
            {
                estado = "PROMOCIÓN";
            }else if (nota < 7 && nota >= 4)
            {
                estado = "APROBADO";
            }else
            {
                estado = "DESAPROBADO";
            }
            
            return $"{texto} ({estado})";
        }
    }
}