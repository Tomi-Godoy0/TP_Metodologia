namespace MetodologiaTP
{
    // Clase 5 - Ejercicio 7
    public class OrdenLlegaAlumno : IOrdenEnAula2
    {
        Aula aula; //Receptor

        public OrdenLlegaAlumno(Aula a)
        {
            this.aula = a;
        }

        //Implemento la interface
        public void ejecutar(IComparable comparable)
        {
            this.aula.nuevoAlumno((IAlumno)comparable);
        }
        
    }
}