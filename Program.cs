namespace logica_de_programacao_csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n=== Exercício 01 ===\n");

        List<int> listaDeNumerosDecrescentes = new List<int>();

        Console.WriteLine("Números crescentes:");
        for (int numerosCrescentes = 1; numerosCrescentes <= 10; numerosCrescentes++)
        {
            Console.WriteLine(numerosCrescentes);
            listaDeNumerosDecrescentes.Add(numerosCrescentes);
        }

        listaDeNumerosDecrescentes.Reverse();

        Console.WriteLine("\nNúmeros decrescentes:");

        foreach (var itensNaListaDecrescente in listaDeNumerosDecrescentes)
            Console.WriteLine(itensNaListaDecrescente);

        Console.WriteLine("\n=== Exercício 02 ===\n");

        while (true)
        {
            Console.WriteLine($"Informe um número para a tabuada:");
            string numeroDigitado = Console.ReadLine();

            decimal numeroTabuada, multiplicacaoTabuada;

            if (decimal.TryParse(numeroDigitado, out numeroTabuada))
            {
                Console.WriteLine($"\nTabuada do número: {numeroTabuada}");

                for (decimal numeroParaMultiplicar = 1; numeroParaMultiplicar <= 10; numeroParaMultiplicar++)
                {
                    multiplicacaoTabuada = numeroTabuada * numeroParaMultiplicar;
                    Console.WriteLine($"{numeroTabuada} X {numeroParaMultiplicar} = {multiplicacaoTabuada}");
                }
                break;
            }
            else
                Console.WriteLine($"Valor digitado inválido\n");
        }

        Console.WriteLine("\n=== Exercício 03 ===\n");

        while (true)
        {
            Console.WriteLine("Digite a temperatura em °C para ser convertida: ");
            string numeroInformadoParaConversao = Console.ReadLine();

            decimal temperaturaEmCelcius, conversaoEmFahrenheit;

            if (decimal.TryParse(numeroInformadoParaConversao, out temperaturaEmCelcius))
            {
                conversaoEmFahrenheit = (temperaturaEmCelcius * 9 / 5) + 32;

                Console.WriteLine($"\nTemperatura em °C informada: {temperaturaEmCelcius}°");
                Console.WriteLine($"Temperatura em Fahrenheit: {conversaoEmFahrenheit}°");
                break;
            }
            else
                Console.WriteLine("Valor informado inválido");
        }

        Console.WriteLine("\n=== Exercício 04 ===\n");

        int numerosDigitados;
        int somaDeNumeros = 0;

        while (true)
        {
            Console.WriteLine("Digite números positivos para soma: ");
            numerosDigitados = int.Parse(Console.ReadLine());

            if (numerosDigitados < 0)
                break;

            somaDeNumeros += numerosDigitados;
        }

        Console.WriteLine($"Soma total dos números: {somaDeNumeros}");

        Console.WriteLine("\n=== Exercício 05 ===\n");

        Console.WriteLine("Digite um número: ");
        int numeroDigitado3 = int.Parse(Console.ReadLine());

        List<int> listaDeNumerosPrimos = new List<int>();

        for (int contadorNumeroPrimo = 2; contadorNumeroPrimo <= numeroDigitado3; contadorNumeroPrimo++)
        {
            bool numeroPrimo = true;

            for (int multiplicadorPrimo = 2; multiplicadorPrimo * multiplicadorPrimo <= contadorNumeroPrimo; multiplicadorPrimo++)
            {
                if (contadorNumeroPrimo % multiplicadorPrimo == 0)
                {
                    numeroPrimo = false;
                    continue;
                }
            }

            if (numeroPrimo)
            {
                listaDeNumerosPrimos.Add(contadorNumeroPrimo);
                continue;
            }
        }

        Console.WriteLine($"Números primos existentes até o número {numeroDigitado3}: ");
        foreach (var itemListaNumerosPrimos in listaDeNumerosPrimos)
        {
            Console.Write($"{itemListaNumerosPrimos} ");
        }

        Console.WriteLine("\n=== Exercício 06 ===\n");

        Console.WriteLine("Digite uma palavra ou um frase para contarmos quantas vogais há: ");
        string informacaoDigitada1 = Console.ReadLine();

        int contadorDeCaracteres = 0;

        char[] listaDeCaracteres1 = informacaoDigitada1.ToCharArray();

        for (int percorreLista = 0; percorreLista < listaDeCaracteres1.Length; percorreLista++)
        {
            switch (listaDeCaracteres1[percorreLista])
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    contadorDeCaracteres++;
                    break;
                default:
                    continue;
            }
        }

        Console.WriteLine($"\nSeu texto digitado: {informacaoDigitada1}");
        Console.WriteLine($"Quantidade de vogais presentes: {contadorDeCaracteres}");


        Console.WriteLine("\n=== Exercício 07 ===\n");

        Console.WriteLine("Digite uma palavra ou uma frase: ");
        string informacaoDigitada = Console.ReadLine();

        //string textoSemEspaco = informacaoDigitada.Replace(" ", "");

        Console.WriteLine($"\nSeu texto: {informacaoDigitada}");

        char[] listaDeCaracteres = informacaoDigitada.ToArray();

        Array.Reverse(listaDeCaracteres);

        Console.Write("\nSeu texto invertido: ");
        foreach (var itensListaDeCaracteres in listaDeCaracteres)
        {
            Console.Write(itensListaDeCaracteres);
        }

        Console.WriteLine("\n\n=== Exercício 08 ===\n");

        Console.WriteLine("Digite um número: ");
        decimal numeroDigitado2 = decimal.Parse(Console.ReadLine());

        decimal fatoracaoDeNumero = 1;

        for (decimal numeroParaFatorar = numeroDigitado2; numeroParaFatorar >= 1; numeroParaFatorar--)
            fatoracaoDeNumero *= numeroParaFatorar;

        Console.WriteLine($"\nO resultado da fatoração do número {numeroDigitado2}! é: {fatoracaoDeNumero}");

        Console.WriteLine("\n=== Exercício 09 ===\n");

        int[] listaDeNumerosInteiros = [10, -3, 98, 7, 42];

        int maiorValor = int.MinValue;
        int menorValor = int.MaxValue;

        Console.Write("Lista de números interios: ");
        foreach (var itemDaLista in listaDeNumerosInteiros)
        {
            Console.Write($"{itemDaLista} ");

            if (itemDaLista > maiorValor)
                maiorValor = itemDaLista;

            if (itemDaLista < menorValor)
                menorValor = itemDaLista;
        }

        Console.WriteLine($"\nMaior número da lista: {maiorValor}");
        Console.WriteLine($"Menor número da lista: {menorValor}");

        Console.WriteLine("\n=== Exercício 10 ===\n");

        int[,] matrizTransposta = {
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        Console.WriteLine("Matriz original: ");

        for (int linhaMatriz = 0; linhaMatriz < matrizTransposta.GetLength(0); linhaMatriz++)
        {
            for (int colunaMatriz = 0; colunaMatriz < matrizTransposta.GetLength(1); colunaMatriz++)
            {
                Console.Write($"{matrizTransposta[linhaMatriz, colunaMatriz]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nMatriz transposta: ");

        for (int linhaMatriz = 0; linhaMatriz < matrizTransposta.GetLength(0); linhaMatriz++)
        {
            for (int colunaMatriz = 0; colunaMatriz < matrizTransposta.GetLength(1); colunaMatriz++)
            {
                Console.Write($"{matrizTransposta[colunaMatriz, linhaMatriz]} ");
            }
            Console.WriteLine();
        }
    }
}
