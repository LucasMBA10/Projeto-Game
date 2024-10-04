using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    // Singleton para o Estado do Jogo
    public class GameState
    {
        private static GameState _instance;
        public static GameState Instance => _instance ??= new GameState();
        public int Pontuacao { get; set; }
        private GameState() { }
    }
}
