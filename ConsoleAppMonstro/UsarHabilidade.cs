using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    public class UsarHabilidade : IAcoesDeCombate
    {
        public void Executar(Monstro atacante, Monstro defensor)
        {
            atacante.UsarHabilidadeEspecial();
        }
    }
}
