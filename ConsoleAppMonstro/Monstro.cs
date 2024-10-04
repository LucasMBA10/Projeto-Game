using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    // Monstros e Factory para criá-los
    public abstract class Monstro
    {
        public string Nome { get; set; }
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int Vida { get; set; }

        public abstract void UsarHabilidadeEspecial();
    }
}
