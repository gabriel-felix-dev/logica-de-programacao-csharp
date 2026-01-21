using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace logica_de_programacao_csharp;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        // Console.Clear();

        while (true)
        {
            Console.WriteLine(@$"Selecione uma opção: 
            1 - Prova 1 - questão 01
            2 - Prova 1 - questão 02
            3 - Prova 1 - questão 03 
            4 - Prova 1 - questão 04 
            5 - Prova 1 - questão 05 
            6 - Prova 2 - questão 01
            7 - Prova 2 - questão 02 
            8 - Prova 2 - questão 03
            9 - Prova 2 - questão 04 
            10 -  Prova 2 - questão 05");
            string opcaoDigitada = Console.ReadLine();

            switch (opcaoDigitada)
            {
                case "1":
                    Prova1Questao1();
                    break;
                case "2":
                    Prova1Questao2();
                    break;
                case "3":
                    Prova1Questao3();
                    break;
                case "4":
                    Prova1Questao4();
                    break;
                case "5":
                    Prova1Questao5();
                    break;
                case "6":
                    Prova2Questao1();
                    break;
                case "7":
                    Prova2Questao2();
                    break;
                case "8":
                    Prova2Questao3();
                    break;
                case "9":
                    Prova2Questao4();
                    break;
                case "10":
                    Prova2Questao5();
                    break;
                default:
                    Console.WriteLine("Opção digitada inválida.\n");
                    continue;
            }
            break;
        }
    }

    static void Prova1Questao1()
    {
        Console.Clear();

        decimal valorProduto = 0;
        int quantidadeProduto = 0;
        decimal valorFrete = 35.00m;
        decimal percentualPromocao = 0.0m;
        bool statusPromocao = false;

        Console.WriteLine("Digite o nome do cliente: ");
        string nomeCliente = Console.ReadLine();

        Console.WriteLine("\nDigite o nome do produto adquirido: ");
        string nomeProduto = Console.ReadLine();


        Console.WriteLine("\nDigite o valor do produto: ");

        while (!decimal.TryParse(Console.ReadLine(), out valorProduto))
            Console.WriteLine("Valor inválido, digite novamente.\n");

        Console.WriteLine("\nDigite a quantidade adquirida: ");

        while (!int.TryParse(Console.ReadLine(), out quantidadeProduto))
            Console.WriteLine("Quantidade digitade inválida, digite novamente.\n");

        while (true)
        {
            Console.WriteLine("\nO produto está em promoção?");
            string statusPromocaoInformado = Console.ReadLine();

            if (statusPromocaoInformado.ToLower().Equals("sim"))
            {
                statusPromocao = true;
                percentualPromocao = 0.12m;
                break;
            }
            else if (statusPromocaoInformado.ToLower().Equals("não") || statusPromocaoInformado.ToLower().Equals("nao"))
                break;
            else
                Console.WriteLine("Status inválido, digite novamente.");
        }

        decimal subtotal = valorProduto * quantidadeProduto;
        decimal valorDesconto = subtotal * percentualPromocao;
        decimal valorFinal = (subtotal - valorDesconto) + valorFrete;

        if (subtotal >= 800)
            valorFrete = 0.0m;

        Console.WriteLine("\n==== FECHAMENTO DE COMPRA ====\n");

        Console.WriteLine($"Cliente: {nomeCliente}");
        Console.WriteLine($"Preço do produto: {nomeProduto:C}");
        Console.WriteLine($"Quantidade do produto: {quantidadeProduto}\n");
        Console.WriteLine($"Subtotal: {subtotal:C}");
        Console.WriteLine($"A promoção está ativa? {(statusPromocao ? "Sim" : "Não")}");
        if (statusPromocao)
            Console.WriteLine($"Desconto de {percentualPromocao:p}: {valorDesconto:C}");
        Console.WriteLine();
        if (valorFrete == 0.0m)
            Console.WriteLine($"Frete grátis");
        else
            Console.WriteLine($"Frete aplicado: {valorFrete:C}");
        Console.WriteLine($"Valor final: {valorFinal:C}");
    }
    static void Prova1Questao2()
    {
        Console.Clear();

        List<decimal> listaDeNotas = new List<decimal>();

        string nomeAluno;
        decimal assiduidadeMinima = 75.0m;
        decimal assiduidadeAluno;
        decimal notaAluno;
        EnumSituacaoAluno situacaoAluno;

        decimal totalDosPesos = 0.0m;
        decimal pesoDeNota1 = 1.0m;
        totalDosPesos += pesoDeNota1;
        decimal pesoDeNota2 = 5.0m;
        totalDosPesos += pesoDeNota2;
        decimal pesoDeNota3 = 4.0m;
        totalDosPesos += pesoDeNota3;

        Console.WriteLine($"\n==== Boletim Final ====\n");

        while (true)
        {
            Console.WriteLine("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(nomeAluno))
                break;
            else
                Console.WriteLine("Nome inválido, digite novamente.\n");
        }

        while (listaDeNotas.Count < 3)
        {
            Console.WriteLine($"Digite a {listaDeNotas.Count + 1}° nota do aluno: ");

            if (!decimal.TryParse(Console.ReadLine(), out notaAluno) || notaAluno == 0 || notaAluno > 10)
                Console.WriteLine($"Nota inválida. Digite apenas um valor entre 0 e 10.");
            else
                listaDeNotas.Add(notaAluno);
        }

        Console.WriteLine($"\nDigite a frenquência do aluno: ");

        while (!decimal.TryParse(Console.ReadLine(), out assiduidadeAluno) || assiduidadeAluno < 0 || assiduidadeAluno > 100)
            Console.WriteLine("Valores digitados inválidos, a assiduidade do aluno deve ser entre 0 e 100. Digite novamente\n");

        List<decimal> listaDeNotasComPesos = new List<decimal> { listaDeNotas[0] * pesoDeNota1, listaDeNotas[1] * pesoDeNota2, listaDeNotas[2] * pesoDeNota3 };

        decimal mediaFinal = listaDeNotasComPesos.Sum() / totalDosPesos;

        if (assiduidadeMinima <= assiduidadeAluno)
        {
            if (mediaFinal < 5)
                situacaoAluno = EnumSituacaoAluno.REPROVADO;

            else if (mediaFinal < 7)
                situacaoAluno = EnumSituacaoAluno.RECUPERAÇÃO;

            else
                situacaoAluno = EnumSituacaoAluno.APROVADO;
        }
        else
            situacaoAluno = EnumSituacaoAluno.REPROVADOPORFALTA;

        Console.WriteLine($"\nNome do aluno: {nomeAluno}");
        Console.WriteLine($"Notas: {listaDeNotas[0]}, {listaDeNotas[1]}, {listaDeNotas[2]}");
        Console.WriteLine($"Média: {mediaFinal:F2}");
        Console.WriteLine($"Frequência: {assiduidadeAluno}");
        if (situacaoAluno.Equals(EnumSituacaoAluno.REPROVADOPORFALTA))
            Console.WriteLine($"\nSituação: Reprovado por falta.");

        else
            Console.WriteLine($"\nSituação: {situacaoAluno}");
    }
    static void Prova1Questao3()
    {
        Console.Clear();

        EnumDesempenhoEstagiarios desempenhoEstagiarios;
        int quantidadeTurmaEstagiarios;
        List<decimal> listaDeMedias = [];
        decimal maiorMedia = decimal.MinValue;
        decimal menorMedia = decimal.MaxValue;
        int contadorDeAprovados = 0;
        int contadorDeReprovados = 0;

        Console.WriteLine($"A turma é composta por quantos estágiarios?");

        while (!int.TryParse(Console.ReadLine(), out quantidadeTurmaEstagiarios) || quantidadeTurmaEstagiarios < 0)
            Console.WriteLine("O valor informado é inválido, digite novamente\n");

        while (listaDeMedias.Count < quantidadeTurmaEstagiarios)
        {
            Console.WriteLine($"\nDigite a média do {listaDeMedias.Count + 1}° estágiario: ");

            if (!decimal.TryParse(Console.ReadLine(), out decimal mediaEstagiario) || mediaEstagiario < 0 || mediaEstagiario > 10)
                Console.WriteLine("O valor digitado para a média é inválido, digite novamente\n");

            else
            {
                listaDeMedias.Add(mediaEstagiario);

                if (mediaEstagiario > maiorMedia)
                    maiorMedia = mediaEstagiario;

                if (mediaEstagiario < menorMedia)
                    menorMedia = mediaEstagiario;

                if (mediaEstagiario >= 7)
                    contadorDeAprovados++;

                if (contadorDeReprovados < 5)
                    contadorDeReprovados++;
            }
        }

        decimal mediaTurma = listaDeMedias.Sum() / listaDeMedias.Count;

        switch (mediaTurma)
        {
            case < 5.0m:
                desempenhoEstagiarios = EnumDesempenhoEstagiarios.FRACA;
                break;
            case < 6.0m:
                desempenhoEstagiarios = EnumDesempenhoEstagiarios.REGULAR;
                break;
            case < 8.0m:
                desempenhoEstagiarios = EnumDesempenhoEstagiarios.BOA;
                break;
            default:
                desempenhoEstagiarios = EnumDesempenhoEstagiarios.EXCELENTE;
                break;
        }

        Console.WriteLine("\n=== Média da Turma de Estagiários ===\n");

        Console.WriteLine($"Média da turma: {mediaTurma:F2}");
        Console.WriteLine($"Maior média: {maiorMedia}");
        Console.WriteLine($"Menor média: {menorMedia}");
        Console.WriteLine($"Quantidade de aprovados: {contadorDeAprovados}");
        Console.WriteLine($"Quantidade de reprovados: {contadorDeReprovados}");
        Console.WriteLine($"Desempenho: {desempenhoEstagiarios}");
    }
    static void Prova1Questao4()
    {
        Dictionary<string, int> dicionarioDeEstoques = new() { { "Mouse", 10 }, { "Teclado", 6 }, { "Cabo HDMI", 18 }, { "Cadeira", 5 } };


        Dictionary<string, int> dicionarioDeEstoquesBaixo = [];

        int contadorDeEstoque = 0;

        Console.WriteLine("=== Estoque Inicial ===\n");

        foreach (var itensNoDicionario in dicionarioDeEstoques)
            Console.WriteLine($"Produto: {itensNoDicionario.Key} - {itensNoDicionario.Value} unidades");

        Console.WriteLine("\n=== Operações ===\n");

        dicionarioDeEstoques.Add("SSD", 7);

        string verificacaoDeProduto = "SSD";

        if (dicionarioDeEstoques.TryGetValue(verificacaoDeProduto, out int quantidadeEmEstoque))
            Console.WriteLine($"Novo produto adicionado ao estoque: {verificacaoDeProduto} - {quantidadeEmEstoque} unidades");

        dicionarioDeEstoques["Teclado"] = 12;

        verificacaoDeProduto = "Teclado";

        if (dicionarioDeEstoques.TryGetValue(verificacaoDeProduto, out int quantidadeEmEstoqueNovo))
            Console.WriteLine($"Nova quantidade após recontagem de estoque: {verificacaoDeProduto} - {quantidadeEmEstoqueNovo} unidades");

        verificacaoDeProduto = "Webcam";

        bool procuraEmEstoque = dicionarioDeEstoques.ContainsKey(verificacaoDeProduto);

        Console.WriteLine($"O produto \"{verificacaoDeProduto}\" existe no estoque? {(procuraEmEstoque ? "Sim" : "Não")}");

        verificacaoDeProduto = "Monitor";

        dicionarioDeEstoques.Remove(verificacaoDeProduto);

        Console.WriteLine($"Produto removido: {verificacaoDeProduto}");

        foreach (var itensNoDicionario in dicionarioDeEstoques)
        {
            if (itensNoDicionario.Value < 8)
            {
                contadorDeEstoque++;
                dicionarioDeEstoquesBaixo.Add(itensNoDicionario.Key, itensNoDicionario.Value);
            }
        }

        int quantidadeTotalDeEstoque = dicionarioDeEstoques.Values.Sum();

        Console.WriteLine("\n===Estoque Final===\n");

        foreach (var itensNoDicionario in dicionarioDeEstoques)
            Console.WriteLine($"Produto: {itensNoDicionario.Key} - {itensNoDicionario.Value} unidades");

        Console.WriteLine($"\nTotal de quantidade de estoque: {quantidadeTotalDeEstoque}");
    }
    // static void Prova1Questao4()
    // {
    //     List<string> listaDeProdutos = ["Mouse", "Teclado", "Monitor", "Cabo HDMI", "Cadeira"];
    //     List<int> listaDeEstoques = [10, 6, 4, 18, 5];

    //     int contadorDeEstoque = 0;

    //     List<string> listaDeProdutosComEstoqueBaixo = [];

    //     Console.WriteLine("=== Estoque Inicial ===\n");

    //     for (int percorreLista = 0; percorreLista < listaDeProdutos.Count; percorreLista++)
    //         Console.WriteLine($"Produto: {listaDeProdutos[percorreLista]} - {listaDeEstoques[percorreLista]} unidades");

    //     Console.WriteLine("\n=== Operações ===\n");

    //     listaDeProdutos.Add("SSD");
    //     listaDeEstoques.Add(7);

    //     listaDeEstoques[1] = 12;

    //     Console.WriteLine($"Produto adicionado no estoque: {listaDeProdutos[5]} - {listaDeEstoques[5]} unidades");

    //     bool contemProduto = listaDeProdutos.Contains("Webcam");

    //     Console.WriteLine($"O produto \"Webcam\" existe no estoque? {(contemProduto ? "Sim" : "Não")}");

    //     for (int percorreLista = 0; percorreLista < listaDeProdutos.Count; percorreLista++)
    //     {
    //         if (listaDeEstoques[percorreLista] < 8)
    //         {
    //             contadorDeEstoque++;

    //             listaDeProdutosComEstoqueBaixo.Add(listaDeProdutos[percorreLista]);
    //         }
    //     }

    //     Console.WriteLine($"Quantidade de produtos com estoque abaixo de 8: {contadorDeEstoque}");

    //     Console.WriteLine($"Lista de produtos com estoque abaixo de 8: ");
    //     foreach (var itensNaLista in listaDeProdutosComEstoqueBaixo)
    //         Console.WriteLine(itensNaLista);

    //     listaDeProdutos.Remove("Monitor");
    //     listaDeEstoques.Remove(4);

    //     Console.WriteLine($"Produto removido: Monitor");

    //     int totalDeProdutosEmEstoque = listaDeEstoques.Sum();

    //     Console.WriteLine($"\n=== Estoque Final ===\n");

    //     for (int percorreLista = 0; percorreLista < listaDeProdutos.Count; percorreLista++)
    //         Console.WriteLine($"Produto: {listaDeProdutos[percorreLista]} - {listaDeEstoques[percorreLista]} unidades");

    //     Console.WriteLine($"\nTotal de produtos: {totalDeProdutosEmEstoque}");
    // }
    static void Prova1Questao5()
    {
        Console.Clear();

        string nomeCliente, formaDePagamentoDigitado;
        string tipoDePagamento = "À vista";
        EnumFormasDePagamento formasDePagamento;
        decimal valorCompra;
        bool cupomParaDesconto = false;
        decimal percentualDescontoComCupom = 0.0m;
        decimal valorDeDescontoComCupom = 0.0m;
        decimal descontoAdicional = 0.0m;
        decimal valorDeDescontoAdicional = 0.0m;
        decimal taxaDeAcrescimo = 0.0m;
        decimal valorDeTaxaDeAcrescimo = 0.0m;
        int quantidadeDeParcelas = 0;
        decimal valorDeParcelas = 0.0m;

        decimal valorFinal = 0.0m;

        while (true)
        {
            Console.WriteLine("Digite o nome do cliente: ");
            nomeCliente = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nomeCliente))
                Console.WriteLine("Nome inválido, digite novamnete\n");

            else
                break;
        }

        Console.WriteLine("\nDigite o valor da compra: ");

        while (!decimal.TryParse(Console.ReadLine(), out valorCompra))
            Console.WriteLine("O valor da compra é inválido, digite novamente");

        while (true)
        {
            Console.WriteLine("\nDigite a forma de pagamento: ");
            formaDePagamentoDigitado = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(formaDePagamentoDigitado))
            {
                Console.WriteLine("A forma de pagamento é inválida, digite novamnete\n");
                continue;
            }
            switch (formaDePagamentoDigitado.ToLower())
            {
                case "pix":
                    formasDePagamento = EnumFormasDePagamento.PIX;
                    break;
                case "credito":
                    formasDePagamento = EnumFormasDePagamento.CREDITO;
                    break;
                case "debito":
                    formasDePagamento = EnumFormasDePagamento.DEBITO;
                    break;
                case "dinheiro":
                    formasDePagamento = EnumFormasDePagamento.DINHEIRO;
                    break;
                default:
                    Console.WriteLine("Forma de pagamento não cadastrada, digite novamente");
                    continue;
            }
            break;
        }

        if (formasDePagamento.Equals(EnumFormasDePagamento.CREDITO))
        {
            Console.WriteLine("\nDigite a quantidade de parcelas: ");

            while (!int.TryParse(Console.ReadLine(), out quantidadeDeParcelas) || quantidadeDeParcelas < 0)
                Console.WriteLine("A quantidade de parcelas é inválida, digite novamente");
        }

        while (true)
        {
            Console.WriteLine("\nO cliente tem cupom? (sim/nao) ");
            string cupomDigitado = Console.ReadLine();

            if (cupomDigitado.ToLower().Equals("sim"))
            {
                percentualDescontoComCupom = 0.1m;
                cupomParaDesconto = true;
                break;
            }
            else if (cupomDigitado.ToLower().Equals("nao"))
                break;

            else
                Console.WriteLine("Informação digitada inválida, digite novamente\n");
        }

        if (cupomParaDesconto)
            valorDeDescontoComCupom = valorCompra * percentualDescontoComCupom;

        switch (formasDePagamento)
        {
            case EnumFormasDePagamento.PIX:
                descontoAdicional = 0.03m;
                valorDeDescontoAdicional = valorDeDescontoComCupom * descontoAdicional;
                valorFinal = valorCompra - valorDeDescontoAdicional - valorDeDescontoComCupom;
                break;

            case EnumFormasDePagamento.DEBITO:
                descontoAdicional = 0.00m;
                valorDeDescontoAdicional = valorDeDescontoComCupom * descontoAdicional;
                valorFinal = valorCompra - valorDeDescontoAdicional - valorDeDescontoComCupom;
                break;

            case EnumFormasDePagamento.DINHEIRO:
                descontoAdicional = 0.05m;
                valorDeDescontoAdicional = valorDeDescontoComCupom * descontoAdicional;
                valorFinal = valorCompra - valorDeDescontoAdicional - valorDeDescontoComCupom;
                break;

            default:
                taxaDeAcrescimo = 0.05m;
                valorDeTaxaDeAcrescimo = valorDeDescontoComCupom * taxaDeAcrescimo;
                valorFinal = valorCompra - valorDeDescontoComCupom + valorDeTaxaDeAcrescimo;

                if (quantidadeDeParcelas > 0)
                {
                    tipoDePagamento = "Parcelado";
                    valorDeParcelas = valorFinal / quantidadeDeParcelas;
                }
                break;
        }

        Console.WriteLine("\n === Compas Online === \n");

        Console.WriteLine($"Cliente: {nomeCliente}\n");

        Console.WriteLine("Cálculo: \n");

        Console.WriteLine($"Valor original da compra: {valorCompra:C}");
        Console.WriteLine($"O cliente tinha cupom de desconto? {(cupomParaDesconto ? "Sim" : "Não")}");
        if (cupomParaDesconto)
            Console.WriteLine($"Valor do Desconto ({percentualDescontoComCupom:p}): {valorDeDescontoComCupom:C}");

        Console.WriteLine($"Forma de pagamento: {formasDePagamento}");
        if (formasDePagamento.Equals(EnumFormasDePagamento.DEBITO))
            Console.WriteLine("Sem desconto Adicional");

        else if (formasDePagamento.Equals(EnumFormasDePagamento.CREDITO))
            Console.WriteLine($"Valor de acréscimo ({taxaDeAcrescimo:p}): {valorDeTaxaDeAcrescimo:C}");

        else
            Console.WriteLine($"Valor de desconto adicional ({descontoAdicional:p}): {valorDeDescontoAdicional:C}");

        Console.WriteLine($"\nValor Final: {valorFinal:C}");
        Console.WriteLine($"Tipo de pagamento: {tipoDePagamento}");
        if (quantidadeDeParcelas > 0)
        {
            Console.WriteLine($"Quantidade de parcelas: {quantidadeDeParcelas}");
            Console.WriteLine($"Valor por parcela: {valorDeParcelas:C}");
        }
    }

    static void Prova2Questao1()
    {
        var nomeCliente = EnumBandeirasDeConsumo.AMARELA;
        decimal consumoDeEnergia = 350.0m;
        decimal valorKwh = 0.72m;

        var descricao = nomeCliente.GetType().GetEnumValues();


        decimal percentualAcrescimoBandeira;
        decimal valorDeDescontoPorBandeira;
        decimal percentualDeDescontoBonus = 0.0m;
        decimal valorDeDescontoExtra = 0.0m;
        decimal valorFinal = 0.0m;

        string inputDigitado = Console.ReadLine();
        // EnumBandeirasDeConsumo[] valores = ;



        decimal valorDaConta = consumoDeEnergia * valorKwh;

        if (consumoDeEnergia < 200)
            percentualDeDescontoBonus = 0.08m;

        if (percentualDeDescontoBonus > 0.00m)
            valorDeDescontoExtra = valorDaConta * percentualDeDescontoBonus;

        // switch (bandeirasDeConsumo)
        // {
        //     case EnumBandeirasDeConsumo.VERDE:
        //         percentualAcrescimoBandeira = 0.0m;
        //         valorDeDescontoPorBandeira = valorDeDescontoExtra * percentualAcrescimoBandeira;
        //         valorFinal = valorDaConta - valorDeDescontoExtra - valorDeDescontoPorBandeira;
        //         break;

        //     case EnumBandeirasDeConsumo.AMARELA:
        //         percentualAcrescimoBandeira = 0.05m;
        //         valorDeDescontoPorBandeira = valorDeDescontoExtra * percentualAcrescimoBandeira;
        //         valorFinal = valorDaConta - valorDeDescontoExtra - valorDeDescontoPorBandeira;
        //         break;

        //     default:
        //         percentualAcrescimoBandeira = 0.1m;
        //         valorDeDescontoPorBandeira = valorDeDescontoExtra * percentualAcrescimoBandeira;
        //         valorFinal = valorDaConta - valorDeDescontoExtra - valorDeDescontoPorBandeira;
        //         break;
        // }

        Console.WriteLine("\n=== Fatura Detalhada ===\n");

        Console.WriteLine($"Cliente: {nomeCliente}\n");
        Console.WriteLine($"Subtotal: \n");
        // Console.WriteLine($"Bandiera: {bandeirasDeConsumo}");


    }
    static void Prova2Questao2() { }
    static void Prova2Questao3() { }
    static void Prova2Questao4() { }
    static void Prova2Questao5() { }

    public enum EnumSituacaoAluno
    {
        APROVADO,
        RECUPERAÇÃO,
        REPROVADO,
        REPROVADOPORFALTA
    }

    public enum EnumDesempenhoEstagiarios
    {
        EXCELENTE,
        BOA,
        REGULAR,
        FRACA
    }

    public enum EnumFormasDePagamento
    {
        DINHEIRO,
        PIX,
        DEBITO,
        CREDITO
    }

    public enum EnumBandeirasDeConsumo
    {
        VERDE = 1,
        [Description("Amarela")]
        AMARELA = 2,
        VERMELHA = 3,
    }
}
