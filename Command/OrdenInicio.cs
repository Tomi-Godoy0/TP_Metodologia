namespace MetodologiaTP
{
    // Clase 5 - Ejercicio 5
    public class OrdenInicio : IOrdenEnAula1
    {
        private Aula aula;

        public OrdenInicio(Aula a)
        {
            this.aula = a;
        }

        //Implemento la interface
        public void ejecutar()
        {
            this.aula.comenzar();
        }
        
    }
}