using System.Text;

namespace MetodologiaTP
{
    //-Ejercicio 2-
    public class GeneradorDeDatosAleatorios
    {

        private static Random rnd = new Random();
        
        //Devuelve entre 0 y max
        public int numeroAleatorio(int max) => rnd.Next(0, max);

        public string stringAleatorio(int cant = 5)
        {
            const string alfabeto = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            StringBuilder token = new StringBuilder();
            
            for (int i = 0; i < cant; i++)
            {
                int indice = rnd.Next(0, alfabeto.Length);
                token.Append(alfabeto[indice]);
            }

            return token.ToString();
        }
    }
}