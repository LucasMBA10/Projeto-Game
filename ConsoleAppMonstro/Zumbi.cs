using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    public class Zumbi : Monstro
    {
        public Zumbi()
        {
            Nome = "Zumbi";
            Ataque = 6;
            Defesa = 5;
            Vida = 80;
        }
        public override void UsarHabilidadeEspecial()
        {
            Console.WriteLine($"{Nome} se regenera! Recuperou vida!");
        }
    }
}
