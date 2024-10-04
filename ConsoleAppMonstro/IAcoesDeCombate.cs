using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    // Strategy para Ações no Combate
    public interface IAcoesDeCombate
    {
        void Executar(Monstro atacante, Monstro defensor);
    }
}
