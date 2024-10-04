using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    public class Defender : IAcoesDeCombate
    {
        public void Executar(Monstro atacante, Monstro defensor)
        {
            defensor.Defesa += 5;
            Console.WriteLine($"{defensor.Nome} se defende, aumentando a defesa!");
        }
    }

}
