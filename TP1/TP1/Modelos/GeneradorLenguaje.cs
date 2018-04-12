using System;

namespace TP1.Modelos
{
    public class GeneradorLenguaje
    {
        public Generado Generado { get; set; }
        public Random Random { get; set; }

        public GeneradorLenguaje()
        {
            Generado = new Generado();
            Random = new Random();
        }

        public Generado GenerarAleatorio(int i)
        {
            Generado.Iteracion = i;
            Generado.NumAleatorio = Random.NextDouble();

            return Generado;
        }
    }
}
