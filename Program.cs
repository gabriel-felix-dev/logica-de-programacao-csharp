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
        Console.Clear();

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

        decimal assiduidadeMinima = 75.0m;
        decimal notaAluno = 0;

        int pesoDeNota1 = 1;
        int pesoDeNota2 = 5;
        int pesoDeNota3 = 4;

        while (listaDeNotas.Count < 3)
        {
            Console.WriteLine($"Digite a {listaDeNotas.Count + 1}° nota do aluno: ");

            if (!decimal.TryParse(Console.ReadLine(), out notaAluno) || notaAluno == 0 || notaAluno > 10)
                Console.WriteLine($"Nota inválida. Digite apenas um valor entre 0 e 10.");
            else
                listaDeNotas.Add(notaAluno);
        }

        List<decimal> listaDeNotasComPesos = new List<decimal>(listaDeNotas[0] * pesoDeNota1, listaDeNotas[1] * pesoDeNota2);
    }
    static void Prova1Questao3() { }
    static void Prova1Questao4() { }
    static void Prova1Questao5() { }
    static void Prova2Questao1() { }
    static void Prova2Questao2() { }
    static void Prova2Questao3() { }
    static void Prova2Questao4() { }
    static void Prova2Questao5() { }
}
