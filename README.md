# Anotações sobre a linguagem de programação C#

## Anotações durante o estudo do treinamento em C# no Microsoft Learn e presquisas avulsas

### Instalação e configuração do ambiente de desenvolvimento

O C# funciona através do SDK .NET

Link para Download: https://dotnet.microsoft.com/pt-br/download

Comando para visualizar a versão do .NET instalado: 

`dotnet --version` / `dotnet --list-sdks`

Caso após a instalação do .NET o comando `dotnet --version` não esteja funcionando, seguir os seguintes passos: 

- Abrir a opções avançadas do computador usando os comando windows + R e digitar sysdm.cpl;
- Ir na aba Avançado;
- Selecionar a opção “Variáveis de Ambiente”;
- Na parte de Variáveis do sistema, selecionar a opção “Path” e clicar em “Editar”;
- Procurar pelo caminho “C:\Program Files\dotnet\” e verificar se na lista de caminhos não há nenhum outro caminho terminado com \dotnet\ que esteja acima do caminho informado;
- Caso haja, clique no primeiro caminho informado e depois clique em “Mover para Cima”;
- Salve tudo e reinicie o PowerShell ou CMD;
- O comando **dotnet --version não** é executado porque o PoweShell ou CMD estão encontrando mais de um caminho para execução do dotnet.exe. Devido a isso ocorre um conflito na hora da utilização da aplicação, sendo necessário a correção do Path nas Configurações Avançadas de Sistema. 

Extensões para o VS Code: 

- C# Dev Kit - microsoft.com
- C# - microsoft.com
- C# Extensions - JosKreativ
- vscode-solution-explorer

C# é uma linguagem com Case Sensitive. A linguagem faz diferença entre letras maiúsculas e minúsculas. Exemplo: Console.WriteLine(); ≠ console.writeline();

### Principais comandos

Para iniciar um novo console e criar um programa: 

`dotnet new console -o nome-do-projeto -n estudo;`

- `-o` cria uma pasta com um nome específico para o projeto;
- `-n` nomeia o arquivo .csproj;

É mais indicado não utilizar o `-n` o comando `dotnet build` for ser executado, será necessário especificar o arquivo **.csproj**.

As versões mais atuais do **dotnet** não criam mais o arquivo **Program.cs** com a estrutura de classe com o nome do arquivo e nem com o método Main. Isso foi inserido para facilitar a utilização por novos usuário. O comando abaixo executa a criação de um novo console e executa a criação do arquivo **Program.cs** com a estrutura de classe e o método Main:

`dotnet new console -o nome-do-projeto --use-program-main`

Comando para criar o git ignore das pastas bin e obj:

`dotnet new gitignore`

Acessar o arquivo .csproj e alterar a linha 7 a tag `<Nullable>` de `enable` para `disable`. Isso permitirá valores nulos.

Comando para compilação: 

`dotnet build`

Extensão do arquivo do C#: **.cs**;

### Execução do Debug

**Necessário ter instalado a extensão vscode-solution-explorer**

Sequência para executar apenas uma área do código por meio do debug do VS Code: 

- Clicar ao lado do número das linhas para deixar uma marcação com uma bola vermelha. Essa marcação delimiratá até aonde o código será lido;
- Clicar no espaço vazio do explorador de arquivos;
- Apertar **F5**, selecionar a linguem **C#** e depois selecionar o projeto que está sendo trabalhado, ele terá o mesmo nome do arquivo .csproj;

Comando para execução de arquivo por meio do terminal: 

`dotnet run;`

## Comando de print na tela: 

`Console.WriteLine()` & `Console.Write()`

Diferença: **WriteLine** realiza uma quebra de linha para a próxima impressão na tela, já **Write** sem a presença do Line não faz essa quebra de linha. 

## Literais de caracteres: 

Aspas simples criam um caractere literal, um **char literal**. Ela vai aceitar apenas **um único** caractere. Já as aspas duplas criam um um dado do tipo **string**. Um valor literal é algo que não sofre altração, é um valor constante. 

Para a impressão de um caractere, tipo **char** literal usa-se o comando abaixo com aspas simples: 

`Console.WriteLine('b');`

Para a impressão de texto do tipo **string**, usa-se o comando abaixo com as aspas duplas:

`Console.WriteLine("Hello, World");`

## Valores literias e tipos de variaveis

### Literais interiros:

Comando para exibição de um valor interiro literal do tipo inteiro (**int**):

`Console.WriteLine(123);`

### Literais de ponto flutuante: 

O C# da três tipos de variaveis para valores decimais: **float**, **double** e **decimal**. Cada tem um grau de precisão diferente:

- Float: 6-9 digitos
- double: 15-17 digitos
- decimal: 28-29 digitos

Para criar um float literal, usa-se a letra **F** após o número. Pode ser usado tanto o minúsculo como maiúsculo:

`Console.WriteLine(0.25F);`

Para criar um double literal basta inserir o número decimal:

`Console.WriteLine(2.625);`

Para criar um decimal literal, usa-se a letra **M** após o número. Pode ser usado como maiúsculo ou minúsculo: 

`Console.WriteLine(12.39816m);`

## Literais boolianos: 

Literais booleanos são representados por **true** ou **false**. O tipo é o bool, abreviação para Boolean. Para a impressão em tela:

`Console.WriteLine(true);`
`Console.WriteLine(false);`

## Declaração de uma variavel

Para se declarar um variavel, primeiro se define o tipo dela e depois nome que ela terá: 

`string nomeUsuario`
`int notaSemestral`
`bool validacaoDeUsuario`

## Definicção de valor em uma variável

Para atribuir um valor à uma variável, deve-se declarar ela e após isso informar o valor que ela armazenará: 

`string primeiroNome;`
`priemiroNome = "Gabriel";`

Para realizar a impressão na tela basta colocar o nome da variável no metódo WriteLine:

`Console.WriteLine(primeiroNome);`

## Interpolação e formatação de impressão:

`\n` => Quebra de linha.
`\t` => Gera um "tab" entre um caractere e outro.
`\"texto\"` => Possibilita deixar os caracteres entre aspas.
`\\C:Users\Gabriel\Documents\\` => Permite imprimir na tela um caminho de pastas do computador.

Exemplo de uso: 

```Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021 \t \t Complete!");
Console.WriteLine("Invoice: 1022 \t\t Complete!");
Console.Write("\nOutpu Directory: \t");
```
 
=> O `@` permite quabra de texto entre linhas e permite usar o caractere `\` sem a necessidade do escape `\\`.

```Console.WriteLine(@"Texto para 
impressão")
```

A interpolação de variáveis ser dá por meio do caractere `$`:

```string nome = "Gabriel";
Console.WriteLine($"Olá, {nome}");
```

A interpolação com o caractere `$` pode ser feita também em variáveis: 

```string nome = "Lucas";
string mensagem = $"Olá, {nome}!";
Console.WriteLine(mensagem);
```
Os caractestes `@` e `$` podem ser usados juntos: 

```string nomeProjeto = "primeiro-projeto";
Console.WriteLine($@"Local de armazenamento do projeto:
    C:\Output\{nomeProjeto}\Data");
```

## Captura de informação

O `ReadLine()` vai retornar uma informação em formato de `string`:

`Console.ReadLine();`
 
### Captura e converção de uma informação

A partir do console, o `ReadLine()` irá capturar uma informação escrita pelo usuário, em seguida essa informação será convertida em um tipo `int` através do `Parse()` e no final sera armazenada na variável **valorInteiro**.

```Console.WriteLine("Digite um valor interio: ")
int valorInterio = int.Parse(Console.ReadLine());
```
