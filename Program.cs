namespace logica_de_programacao_csharp;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        // Devido aos Arrays serem do tipo de referência (Reference Type), devemos iniciar com o "new". 
        // => Arrays, listas, armazenam a referência de uma informação e não a informação em si.

        // var meuArraySemDeclaracao1 = new int[5]; // Foi criado um Array do tipo inteiro com 5 posições e atribuido na variável meuArray.

        // var meuArraySemDeclaracao2 = new int[5] { 1, 23, 63, 45, 55 }; // Foi criado um Array do tipo inteiro com 5 posições, cada posição com o seu valor e atribuido na variável meuArray. O Array sendo criado dessa forma com a declaração de "var" se torna necessário iniciar com o "new".

        // meuArraySemDeclaracao1[0] = 12; // => Insere o valor 12 na posição 0 do Array.

        // int[] meuArraySemDeclaracao3 = { }; // => Outra forma de criar um Array. Como o Array foi iniciado apartir do tipo, não precisamos iniciar o Array com o "new".

        // int[] meuArrayDeclarado = { 1, 23, 63, 45, 55 }; // => Outra forma de criar um Array instanciado com um valores definidos.

        // Console.WriteLine(meuArrayDeclarado[0]); // => Imprime a posição 0, a primeira posição, do Array.
        // Console.WriteLine(meuArrayDeclarado[1]);
        // Console.WriteLine(meuArrayDeclarado[2]);
        // Console.WriteLine(meuArrayDeclarado[3]);
        // Console.WriteLine(meuArrayDeclarado[4]);


        // //----------------------------------------------------------
        // var meuArrayDeclarado2 = new Teste[2]; // Cria um Array com o tipo sendo uma Struct chamada Teste usando o "new" e que tem tamanho 2;
        // meuArrayDeclarado2[0] = new Teste(); // Define a posição 0 com uma nova struct
        // meuArrayDeclarado2[1] = new Teste(); // Define a posição 1 com uma nova struct

        // Console.WriteLine(meuArrayDeclarado2[0].Hello("Hello")); // Inicia a struct da posição 0 e ativa o método Hello colocando um dado no parâmetro;
        // Console.WriteLine(meuArrayDeclarado2[1].Hello("To Heaven"));


        // //----------------------------------------------------------
        // Teste[] meuArrayDeclarado3 = { new Teste(), new Teste() }; // Cria um Array sendo do tipo struct e que já está recebendo as informações. 

        // Console.WriteLine(meuArrayDeclarado3[0].Hello("Say Hello")); // Imprime a informação da posição 0 do Array e referencia o método Hello informando o dado para o parametro.
        // Console.WriteLine(meuArrayDeclarado3[1].Hello("To Heaven"));

        var meuArray = new int[5] { 1, 2, 3, 4, 5 };
        meuArray[0] = 12;

        // O for começa com a posição inicial do Array (0);
        // Verifica se a variável "item" é menor que o tamnho total do Array (meuArray.Length);
        // Se item continuar sendo menor que o tamanho total do Array, incremente o item (item++).
        // for (var item = 0; item < meuArray.Length; item++)
        // {
        //     Console.WriteLine(meuArray[item]); // Imprime a posição do array conforme o número que estiver na "var item" do for.
        // }

        // Console.WriteLine(" ");

        // var meuArray2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // for (var item = 0; item < meuArray2.Length; item++)
        // {
        //     Console.WriteLine(meuArray2[item]);
        // }

        foreach (var item in meuArray) // for(para) each(cada) => para cada "item" no (in) "meuArray" = imprima na tela a var item.
        {
            Console.WriteLine(item); // Imprime na tela a var item com os valores das posições do "meuArray"
        }

        var funcionario = new Funcionarios[5]; // Cria um Array de 5 posições com base em uma struct
        funcionario[0] = new Funcionarios() { Id = 1515, Name = "João" }; // Insere na posição 0 a informação de uma nova struct Funcionarios com dados nas propriedades Id e Name. 

        foreach (var funcionarios in funcionario) // Cria o foreach e para cada var funcionarios em funcionario ==>
        {
            Console.WriteLine(funcionarios.Id); //==> Deverá imprimir o Id e o Name.
            Console.WriteLine(funcionarios.Name);
        }
    }
    /*
        enum ETipoDeProduto{
            Produto = 1,
            Servico = 2
        }

        struct Produto{

            public int Id;
            public string Titulo;
            public float Preco;
            public ETipoDeProduto Tipo;

            public Produto(int id, string titulo, float preco, ETipoDeProduto tipo){

                Id = id;
                Titulo = titulo;
                Preco = preco;
                Tipo = tipo;

            }

            public float PrecoEmDolar(float dolar){
                return Preco * dolar;
            }
        }

        struct Teste
        {
            public int Id;
            public string Hello(string texto)
            {
                return texto;
            }

        }
        */

    public struct Funcionarios
    {
        public int Id;
        public string Name;
    }

}
