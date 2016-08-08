using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto.Strategy
{
    class Desconto
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public double Valor { get; set; }
        public ICalculadora Calculo { get; set; }      

    }
}
