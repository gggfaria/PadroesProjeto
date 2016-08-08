using PadroesProjeto.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadroesProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Double ValorProduto = 850.50;
            Desconto aniversario = new Desconto();
            aniversario.Valor = 0.5;
            aniversario.DataInicio = DateTime.Now;
            aniversario.Calculo = new Subtracao();

            ValorProduto = aniversario.Calculo.Calcular(ValorProduto, aniversario.Valor);
           

            Console.WriteLine(ValorProduto);


            Console.ReadKey();
        }
    }
}
