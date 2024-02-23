using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class CalculoOperacoes
    {
        AtribuiValores atv;
        AtribuiOperacao ato;

        public CalculoOperacoes(AtribuiValores atv, AtribuiOperacao ato)
        {
            this.atv = atv;
            this.ato = ato;
        }

        public int Execute()
        {
            int resultado = 0;
            int num1 = atv.ObterValor1();
            int num2 = atv.ObterValor2();

            switch (ato.ObterOperacao())
            {
                case 1:
                    {
                        resultado = num1 + num2; break;
                    }
                case 2:
                    {
                        resultado = num1 - num2; break;
                    }
                case 3:
                    {
                        resultado = num1 * num2; break;
                    }
                case 4:
                    {
                        if (num2 != 0)
                        {
                            resultado = num1 / num2; break;
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero.");
                        }
                        break;
                    }
                default:
                        Console.WriteLine("Número inválido, digite outro numero");
                        break;                  
            }
            return resultado;
        }
    }
}
