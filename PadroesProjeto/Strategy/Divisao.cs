using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Strategy
{
    class Divisao:ICalculadora
    {
        public double Calcular(double a, double b)
        {
            double resultado = b != 0 ? a / b : 0;
            return resultado;

        }
    }
}
