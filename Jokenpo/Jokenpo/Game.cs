using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo
{
    class Game
    {
        public enum Resultado
        {
            Ganhar,
            Perder,
            Empatar
        }

        public static Image[] Images =
        {
            Image.FromFile("imagens/pedra.png"),
            Image.FromFile("imagens/tesoura.png"),
            Image.FromFile("imagens/papel.png")
        };

        public Image ImgPc { get; private set; }
        public Image ImgPlayer { get; private set; }

        private int EscolhaPc()
        {
            //Sera usado como parametro aleatorio os milisegundos (0 - 1000) do pc
            int mil = DateTime.Now.Millisecond;

            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 33 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

        public Resultado Jogar (int jogador)
        {
            int jogadapc = EscolhaPc();

            ImgPlayer = Images[jogador];
            ImgPc = Images[jogadapc];

            //codição para definir a partir dos milisegundos.
            if (jogador == jogadapc)
            {
                return Resultado.Empatar;
            }
            else if ((jogador == 0 && jogadapc == 1) || (jogador == 1 && jogadapc == 2) || (jogador == 2 && jogadapc == 0))
            {
                return Resultado.Ganhar;
            }
            else 
            {
                return Resultado.Perder;
            }
        }
    }
}
