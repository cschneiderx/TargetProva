using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Program
{
    // Classe para a Questão 3: Representa os dados de faturamento diário
    public class Faturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Escolha a questão que deseja executar:");
            Console.WriteLine("1 - Questão 1: Valor final da variável SOMA");
            Console.WriteLine("2 - Questão 2: Verificar número na sequência de Fibonacci");
            Console.WriteLine("3 - Questão 3: Análise de faturamento diário");
            Console.WriteLine("4 - Questão 4: Percentual de representação por estado");
            Console.WriteLine("5 - Questão 5: Inverter string");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcao)
            {
                case 1:
                    Questao1();
                    break;
                case 2:
                    Questao2();
                    break;
                case 3:
                    Questao3();
                    break;
                case 4:
                    Questao4();
                    break;
                case 5:
                    Questao5();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void Questao1()
    {
        int INDICE = 13, SOMA = 0, K = 0;
        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }
        Console.WriteLine($"Valor final da variável SOMA: {SOMA}");
    }

    static void Questao2()
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        bool pertence = false;

        while (a <= numero)
        {
            if (a == numero)
            {
                pertence = true;
                break;
            }
            int proximo = a + b;
            a = b;
            b = proximo;
        }

        if (pertence)
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
    }

    static void Questao3()
    {
        Console.Write("Digite o caminho completo do arquivo faturamento.json (ou deixe vazio para usar o padrão): ");
        string caminhoArquivo = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(caminhoArquivo))
        {
            caminhoArquivo = "faturamento.json"; // Caminho padrão
        }

        if (!File.Exists(caminhoArquivo))
        {
            Console.WriteLine($"Arquivo {caminhoArquivo} não encontrado. Por favor, verifique o caminho.");
            return;
        }

        string jsonString = File.ReadAllText(caminhoArquivo);
        List<Faturamento> faturamentos = JsonConvert.DeserializeObject<List<Faturamento>>(jsonString);
        var faturamentoValido = faturamentos.Where(f => f.valor > 0).ToList();

        if (faturamentoValido.Count == 0)
        {
            Console.WriteLine("Nenhum valor de faturamento foi encontrado para o cálculo.");
            return;
        }

        double menorFaturamento = faturamentoValido.Min(f => f.valor);
        double maiorFaturamento = faturamentoValido.Max(f => f.valor);
        double mediaMensal = faturamentoValido.Average(f => f.valor);
        int diasAcimaDaMedia = faturamentoValido.Count(f => f.valor > mediaMensal);

        Console.WriteLine($"Menor valor de faturamento: R$ {menorFaturamento:F2}");
        Console.WriteLine($"Maior valor de faturamento: R$ {maiorFaturamento:F2}");
        Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
    }

    static void Questao4()
    {
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double faturamentoTotal = sp + rj + mg + es + outros;

        double percentualSP = (sp / faturamentoTotal) * 100;
        double percentualRJ = (rj / faturamentoTotal) * 100;
        double percentualMG = (mg / faturamentoTotal) * 100;
        double percentualES = (es / faturamentoTotal) * 100;
        double percentualOutros = (outros / faturamentoTotal) * 100;

        Console.WriteLine("Percentual de representação por estado:");
        Console.WriteLine($"SP: {percentualSP:F2}%");
        Console.WriteLine($"RJ: {percentualRJ:F2}%");
        Console.WriteLine($"MG: {percentualMG:F2}%");
        Console.WriteLine($"ES: {percentualES:F2}%");
        Console.WriteLine($"Outros: {percentualOutros:F2}%");
    }

    static void Questao5()
    {
        Console.Write("Digite uma string para inverter: ");
        string input = Console.ReadLine();
        char[] chars = input.ToCharArray();

        for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
        {
            char temp = chars[i];
            chars[i] = chars[j];
            chars[j] = temp;
        }

        string resultado = new string(chars);
        Console.WriteLine($"String invertida: {resultado}");
    }
}
