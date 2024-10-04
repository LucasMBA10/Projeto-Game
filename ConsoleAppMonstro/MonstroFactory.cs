using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMonstro
{
    public static class MonstroFactory
    {
        public static Monstro CriarMonstro(string tipo)
        {
            return tipo.ToLower() switch
            {
                "dragao" => new Dragao(),
                "zumbi" => new Zumbi(),
                _ => throw new ArgumentException("Tipo de monstro desconhecido")
            };
        }
    }
}
