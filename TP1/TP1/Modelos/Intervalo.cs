namespace TP1.Modelos
{
    public class Intervalo
    {
        public Intervalo(double limiteInferior, double limiteSuperior)
        {
            LimiteInferior = limiteInferior;
            LimiteSuperior = limiteSuperior;
        }

        public int CantidadObservaciones { get; set; }

        public double LimiteSuperior { get; set; }

        public double LimiteInferior { get; set; }
    }
}

