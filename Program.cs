namespace logica_de_programacao_csharp;

class Program
{
    static void Main(string[] args)
    {
        CalculadoraGPA();
    }

    static void CalculadoraGPA()
    {
        string nomeAluno = "Sophia Johnson";
        string cursoEscola1 = "Inglês 101";
        string cursoEscola2 = "Algebra 101 ";
        string cursoEscola3 = "Biologia 101";
        string cursoEscola4 = "Ciência da computação I";
        string cursoEscola5 = "Psicologia 101";

        int horasCreditoCurso1 = 3;
        int horasCreditoCurso2 = 3;
        int horasCreditoCurso3 = 4;
        int horasCreditoCurso4 = 4;
        int horasCreditoCurso5 = 3;

        int grauA = 4;
        int grauB = 3;

        int curso1Grau = grauA;
        int curso2Grau = grauB;
        int curso3Grau = grauB;
        int curso4Grau = grauB;
        int curso5Grau = grauA;

        int horasCreditoTotais = 0;
        horasCreditoTotais += horasCreditoCurso1;
        horasCreditoTotais += horasCreditoCurso2;
        horasCreditoTotais += horasCreditoCurso3;
        horasCreditoTotais += horasCreditoCurso4;
        horasCreditoTotais += horasCreditoCurso5;

        int pontosGrauTotais = 0;
        pontosGrauTotais += horasCreditoCurso1 * curso1Grau;
        pontosGrauTotais += horasCreditoCurso2 * curso2Grau;
        pontosGrauTotais += horasCreditoCurso3 * curso3Grau;
        pontosGrauTotais += horasCreditoCurso4 * curso4Grau;
        pontosGrauTotais += horasCreditoCurso5 * curso5Grau;

        decimal grauDePontosMaximos = (decimal)pontosGrauTotais / horasCreditoTotais;

        int digitoPrincipal = (int)grauDePontosMaximos;
        int primeiroDigito = (int)(grauDePontosMaximos * 10) % 10;
        int segundoDigito = (int)(grauDePontosMaximos * 100) % 10;

        Console.WriteLine($"Estudande: {nomeAluno}\n");
        Console.WriteLine($"Curso\t\t\tGrau\tCrédito Horas");
        Console.WriteLine($"{cursoEscola1}\t\t{curso1Grau}\t\t{horasCreditoCurso1}");
        Console.WriteLine($"{cursoEscola2}\t\t{curso2Grau}\t\t{horasCreditoCurso2}");
        Console.WriteLine($"{cursoEscola3}\t\t{curso3Grau}\t\t{horasCreditoCurso3}");
        Console.WriteLine($"{cursoEscola4}\t{curso4Grau}\t\t{horasCreditoCurso4}");
        Console.WriteLine($"{cursoEscola5}\t\t{curso5Grau}\t\t{horasCreditoCurso5}");

        Console.WriteLine($"\nFinal GPA:\t\t{digitoPrincipal}.{primeiroDigito}{segundoDigito}");
    }
}
