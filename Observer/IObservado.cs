namespace MetodologiaTP
{
    //- Ejercicio 12 -
    public interface IObservado
    {
        //Permite agregar y sacar a quienes quieren el cambio
        public void agregarObservador(IObservador o);
        public void quitarObservador(IObservador o);
        public void notificar();
    }
}