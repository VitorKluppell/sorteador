int BoasVindas(int opcaoEscolhida, int quantidadeNumeros)
{
    Console.WriteLine("Seja bem-vindo(a) ao sorteador!");
    opcaoEscolhida = EscolherOpcao("O que você deseja sortear? Digite (1) = Números / Digite (2) = Outros ", 1, 2);

    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine("Você escolheu: Números");
            Console.WriteLine("Quantos números?");
            quantidadeNumeros = QuantidadeElementos(int.MaxValue, string.Empty);
            SorteioNumeros(quantidadeNumeros);
            break;
        case 2:
            Console.WriteLine("Você escolheu: Outros");
            Console.WriteLine("Quantos itens?");
            int quantidadeItens = QuantidadeElementos(int.MaxValue, string.Empty);
            SorteioItens(quantidadeItens, string.Empty);
            break;
        default:
            Console.WriteLine("Feche o sorteador e tente novamente.");
            break;
    }
    return opcaoEscolhida;
}
int EscolherOpcao(string instrucaoTela, int opcao1, int opcao2)
{
    Console.WriteLine(instrucaoTela);

    int opcaoEscolhida;
    if (!int.TryParse(Console.ReadLine(), out opcaoEscolhida) || (opcaoEscolhida != opcao1 && opcaoEscolhida != opcao2))
    {
        Console.WriteLine("Opção inválida!");
    }

    return opcaoEscolhida;

}


int QuantidadeElementos(int quantidade, string instrucaoTela)
{
    Console.WriteLine(instrucaoTela);
    while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0)
    {
        Console.WriteLine("Erro! Por favor tente novamente.");
    }

    return quantidade;
}

int SorteioItens(int quantidade, string itemSorteado)
{
    string[] itens = new string[quantidade];
    for (int i = 0; i < quantidade; i++)
    {
        Console.Write($"Digite o item {i + 1}: ");
        itens[i] = Console.ReadLine();
    }

    Random random = new Random();
    int posicaoSorteada = random.Next(0, quantidade);
    itemSorteado = itens[posicaoSorteada];

    Console.Write($"O ITEM SORTEADO É: {itemSorteado}");
    return 1;
}

int SorteioNumeros(int quantidade)
{
    Random random = new Random();

    
    int numeroSorteado = random.Next(1, quantidade +1);
    Console.Write($"O NÚMERO SORTEADO É: {numeroSorteado}");

    return 1;
}
void Iniciar()
{
    BoasVindas(int.MaxValue, int.MaxValue);
}
Iniciar();
