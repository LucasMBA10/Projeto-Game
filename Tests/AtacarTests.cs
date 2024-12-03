using ConsoleAppMonstro;

namespace Tests
{
    public class AtacarTests
    {
        [Fact]
        public void Executar_Deve_ReduzirVidaDoDefensor_CasoDanoSejaPositivo()
        {
            // Arrange
            var atacante = new Dragao();
            var defensor = new Zumbi();
            var atacar = new Atacar();

            // Act
            atacar.Executar(atacante, defensor);

            // Assert
            Assert.True(defensor.Vida < 80); // Vida inicial do Zumbi é 80
        }

        [Fact]
        public void Executar_NaoDeveReduzirVidaDoDefensor_CasoDanoSejaZeroOuNegativo()
        {
            // Arrange
            var atacante = new Zumbi(); // Ataque = 6
            var defensor = new Dragao(); // Defesa = 8
            var atacar = new Atacar();

            // Act
            atacar.Executar(atacante, defensor);

            // Assert
            Assert.Equal(100, defensor.Vida); // Vida inicial do Dragão é 100
        }
    }
}