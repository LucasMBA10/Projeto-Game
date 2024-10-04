using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    // Observer para notificar mudanças no estado do jogo
    public class Jogador
    {
        public string Nome { get; set; }
        public Monstro MonstroAtual { get; set; }

        public Jogador(string nome, Monstro monstro)
        {
            Nome = nome;
            MonstroAtual = monstro;
        }

        public void NotificarEstado()
        {
            Console.WriteLine($"{MonstroAtual.Nome} do jogador {Nome} tem {MonstroAtual.Vida} de vida restante.");
        }
    }
}
