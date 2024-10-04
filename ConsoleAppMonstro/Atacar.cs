using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    public class Atacar : IAcoesDeCombate
    {
        public void Executar(Monstro atacante, Monstro defensor)
        {
            int dano = atacante.Ataque - defensor.Defesa;
            if (dano > 0)
            {
                defensor.Vida -= dano;
                Console.WriteLine($"{atacante.Nome} atacou {defensor.Nome} causando {dano} de dano!");
            }
            else
            {
                Console.WriteLine($"{atacante.Nome} atacou, mas {defensor.Nome} defendeu completamente!");
            }
        }
    }
}
