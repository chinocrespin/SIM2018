using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Montecarlo
{
    public class RandomResultado
    {
        public RandomResultado(double valor, double random)
        {
            Valor = valor;
            Random = random;
        }

        public double Valor { get; set; }
        public double Random { get; set; }
    }
}
