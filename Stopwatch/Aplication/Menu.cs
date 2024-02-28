using System.Threading.Channels;

namespace Aplication
{
    public class Menu
    {
        public void Execute()
        {
            PreStart prestart = new PreStart();    
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 10m = 10 minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();  //Faz a conversão de letras para minusculo, caso o usuario digite 's' ou 'm' maiusculo.
            char type = char.Parse(data.Substring(data.Length - 1, 1)); // Aqui fazemos a seleção da letra, utilizando substring de algum elemento, no caso de 'data', (posição, quantidade de item a pegar). Nesse caso contamos o tamanho das string e subtraimos 1, para achar a ultima posição, e selecionamos ela.
            int time = int.Parse(data.Substring(0,data.Length - 1)); //Aqui teremos que pegar todos os caracteres menos o ultimo 's'. Utilizamos novamente 'Substring', nesse caso paegamos apartir da posição 0, todos os caracteres menos o ultimo.

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            prestart.Execute(time * multiplier);
        }
    }
}
