using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    public class GameSaveManager
    {
        private Stack<GameMemento> _saves = new Stack<GameMemento>();
        public void SaveGame()
        {
            _saves.Push(new GameMemento(GameState.Instance.Pontuacao));
            Console.WriteLine("Progresso do jogo salvo!");
        }
        public void LoadGame()
        {
            if (_saves.Count > 0)
            {
                var memento = _saves.Pop();
                GameState.Instance.Pontuacao = memento.Pontuacao;
                Console.WriteLine("Progresso do jogo carregado!");
            }
            else
            {
                Console.WriteLine("Nenhum progresso salvo encontrado.");
            }
        }
    }

}
