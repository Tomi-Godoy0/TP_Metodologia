namespace MetodologiaTP
{
    public interface IIterador
    {
        IComparable Actual();
        void Primero();
        void Siguiente();
        bool Fin();
    }

    public interface IIterable
    {
        IIterador CrearIterador();
    }
}