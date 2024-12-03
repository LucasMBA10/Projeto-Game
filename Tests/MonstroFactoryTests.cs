using ConsoleAppMonstro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class MonstroFactoryTests
    {
        [Theory]
        [InlineData("dragao", typeof(Dragao))]
        [InlineData("zumbi", typeof(Zumbi))]
        public void CriarMonstro_DeveRetornarInstanciaCorreta(string tipo, Type esperado)
        {
            // Act
            var monstro = MonstroFactory.CriarMonstro(tipo);

            // Assert
            Assert.IsType(esperado, monstro);
        }

        [Fact]
        public void CriarMonstro_DeveLancarExcecao_ParaTipoDesconhecido()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => MonstroFactory.CriarMonstro("invalido"));
        }
    }
}
