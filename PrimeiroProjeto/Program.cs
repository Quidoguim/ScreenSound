// Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Screen Sound";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso" };

Dictionary<string, List<int>> bandasListadas = new Dictionary<string, List<int>>();
bandasListadas.Add("Linkin Park", new List<int> { 10, 8, 6 });
bandasListadas.Add("RHCP", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            MostrarTodasAsBandas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case -1:
            Console.WriteLine("Programa finalizado.");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de uma banda:");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!; //Exclamação para não trabalhar com valor nulo.
    bandasListadas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarTodasAsBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Todas as bandas cadastradas:");

    //for (int i = 0;  i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}

    foreach (string banda in bandasListadas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Thread.Sleep(4000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma banda:");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasListadas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota você dará para a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasListadas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda:");
    Console.Write("Digite o nome da banda que você deseja exibir a média: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasListadas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasListadas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é: {notasDaBanda.Average()}.");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

ExibirOpcoesDoMenu();