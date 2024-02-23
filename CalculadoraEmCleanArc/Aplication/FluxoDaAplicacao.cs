using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication
{
    public class FluxoDaAplicacao
    {
        public void Execute()
        {
            AtribuiValores atribuiValores = new AtribuiValores();
            AtribuiOperacao atribuiOperacao = new AtribuiOperacao();
            CalculoOperacoes calculoOperacoes = new CalculoOperacoes(atribuiValores, atribuiOperacao);

            Console.WriteLine("Qual operação deseja fazer: ");
            Console.WriteLine("1- Adição ");
            Console.WriteLine("2- Subtração ");
            Console.WriteLine("3- Multiplicação ");
            Console.WriteLine("4- Divisão ");

            Console.WriteLine("Digite o numero da operação desejada");
            atribuiOperacao.GravaOperacao();

            Console.Write("Digite o primeiro valor: ");
            atribuiValores.GravaValor1();
            Console.Write("Digite o segundo valor: ");
            atribuiValores.GravaValor2();


            Console.WriteLine("O resultado é: " + calculoOperacoes.Execute());
        }
    }
}
