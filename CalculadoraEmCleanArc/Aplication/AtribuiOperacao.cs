using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class AtribuiOperacao
    {
        Operacao operacao = new Operacao();
        public void GravaOperacao()
        {
            operacao.NumOperacao = int.Parse(Console.ReadLine());
        }
        public int ObterOperacao()
        {
            int valorOperacao = operacao.NumOperacao;
            return valorOperacao;
        }

    }
}
