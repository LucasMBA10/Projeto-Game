using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    // Memento para salvar o progresso do jogo
    public class GameMemento
    {
        public int Pontuacao { get; set; }
        public GameMemento(int pontuacao)
        {
            Pontuacao = pontuacao;
        }
    }

}
