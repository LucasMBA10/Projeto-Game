namespace ConsoleAppMonstro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Batalha de Monstros!");
            var saveManager = new GameSaveManager();

            Console.WriteLine("Digite o nome do Jogador 1:");
            string nomeJogador1 = Console.ReadLine();
            Console.WriteLine("Escolha o monstro do Jogador 1 (dragao/zumbi):");
            string tipoMonstro1 = Console.ReadLine();
            var jogador1 = new Jogador(nomeJogador1, MonstroFactory.CriarMonstro(tipoMonstro1));

            Console.WriteLine("Digite o nome do Jogador 2:");
            string nomeJogador2 = Console.ReadLine();
            Console.WriteLine("Escolha o monstro do Jogador 2 (dragao/zumbi):");
            string tipoMonstro2 = Console.ReadLine();
            var jogador2 = new Jogador(nomeJogador2, MonstroFactory.CriarMonstro(tipoMonstro2));

            IAcoesDeCombate acaoAtacar = new Atacar();
            IAcoesDeCombate acaoDefender = new Defender();
            IAcoesDeCombate acaoHabilidade = new UsarHabilidade();

            bool jogoAtivo = true;
            while (jogoAtivo)
            {
                Console.WriteLine("\nTurno do Jogador 1: Escolha uma ação (atacar/defender/habilidade/salvar/sair):");
                string acaoJogador1 = Console.ReadLine().ToLower();
                switch (acaoJogador1)
                {
                    case "atacar":
                        acaoAtacar.Executar(jogador1.MonstroAtual, jogador2.MonstroAtual);
                        break;
                    case "defender":
                        acaoDefender.Executar(jogador1.MonstroAtual, jogador2.MonstroAtual);
                        break;
                    case "habilidade":
                        acaoHabilidade.Executar(jogador1.MonstroAtual, jogador2.MonstroAtual);
                        break;
                    case "salvar":
                        saveManager.SaveGame();
                        break;
                    case "sair":
                        jogoAtivo = false;
                        continue;
                }
                jogador2.NotificarEstado();

                if (jogador2.MonstroAtual.Vida <= 0)
                {
                    Console.WriteLine("Jogador 1 venceu!");
                    break;
                }

                Console.WriteLine("\nTurno do Jogador 2: Escolha uma ação (atacar/defender/habilidade/salvar/sair):");
                string acaoJogador2 = Console.ReadLine().ToLower();
                switch (acaoJogador2)
                {
                    case "atacar":
                        acaoAtacar.Executar(jogador2.MonstroAtual, jogador1.MonstroAtual);
                        break;
                    case "defender":
                        acaoDefender.Executar(jogador2.MonstroAtual, jogador1.MonstroAtual);
                        break;
                    case "habilidade":
                        acaoHabilidade.Executar(jogador2.MonstroAtual, jogador1.MonstroAtual);
                        break;
                    case "salvar":
                        saveManager.SaveGame();
                        break;
                    case "sair":
                        jogoAtivo = false;
                        continue;
                }
                jogador1.NotificarEstado();

                if (jogador1.MonstroAtual.Vida <= 0)
                {
                    Console.WriteLine("Jogador 2 venceu!");
                    break;
                }
            }
        }
    }
}
