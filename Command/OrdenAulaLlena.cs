namespace MetodologiaTP
{
    // Clase 5 - Ejercicio 5
    public class OrdenAulaLlena : IOrdenEnAula1
    {
        private Aula aula; //Nuestro receptor

        public OrdenAulaLlena(Aula a)
        {
            this.aula = a;
        }

        //Implemento la interface
        public void ejecutar()
        {
            this.aula.claseLista();
        }
    }
}