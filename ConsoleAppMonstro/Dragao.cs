using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    public class Dragao : Monstro
    {
        public Dragao()
        {
            Nome = "Dragão";
            Ataque = 10;
            Defesa = 8;
            Vida = 100;
        }
        public override void UsarHabilidadeEspecial()
        {
            Console.WriteLine($"{Nome} usa Fogo! Causou dano extra!");
        }
    }
}
