using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Montecarlo.Utilidades
{
    public class Cronometro
    {
        private DateTime Inicio { get; set; }
        private DateTime Fin { get; set; }

        public void Iniciar()
        {
            Inicio = DateTime.Now;
        }

        public void Finalizar()
        {
            Fin = DateTime.Now;
        }

        public TimeSpan TiempoTranscurrido()
        {
            return Inicio - Fin;
        }
    }
}
