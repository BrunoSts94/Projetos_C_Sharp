using Entities;

namespace Aplication
{
    public class AtribuiValores
    {
        Valores valores = new Valores();

        public void GravaValor1()
        {
            valores.Valor1 = int.Parse(Console.ReadLine());
        }
        public int ObterValor1()
        {
            int valor1 = valores.Valor1;
            return valor1;
        }

        public void GravaValor2()
        {
            valores.Valor2 = int.Parse(Console.ReadLine());
        }
        public int ObterValor2()
        {
            int valor2 = valores.Valor2;
            return valor2;
        }
    }
}
