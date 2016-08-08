using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Strategy
{
    class Multiplicacao : ICalculadora
    {
        public double Calcular(double a, double b)
        {
            double resultado = a * b;
            return resultado;
        }
    }
}
