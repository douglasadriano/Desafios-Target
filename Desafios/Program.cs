using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n# Desafio 1: Cálculo da Soma");
        Desafio1();

        Console.WriteLine("\n# Desafio 2: Verificação na Sequência de Fibonacci");
        Desafio2();

        Console.WriteLine("\n# Desafio 3: Análise do Faturamento Diário");
        FaturamentoDiario();

        Console.WriteLine("\n# Desafio 4: Percentual de Representação por Estado");
        PercentualRepresentacao();

        Console.WriteLine("\n# Desafio 5: Inversão de String");
        InverterString();
    }

    static void Desafio1()
    {
        int INDICE = 13, SOMA = 0, K = 0;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine($"O valor da variável SOMA é: {SOMA}");
    }

    static void Desafio2()
    {
        Console.Write("Informe um número para verificar na sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());
        Fibonacci(numero);
    }

    static void Fibonacci(int numero)
    {
        int a = 0, b = 1, c = 0;
        bool pertence = false;

        while (c <= numero)
        {
            if (c == numero)
            {
                pertence = true;
                break;
            }
            c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine(pertence
            ? $"O número {numero} pertence à sequência de Fibonacci."
            : $"O número {numero} não pertence à sequência de Fibonacci.");
    }

    static void FaturamentoDiario()
    {
        List<Faturamento> faturamentos = new List<Faturamento>
        {
            new Faturamento(1, 22174.1664),
            new Faturamento(2, 24537.6698),
            new Faturamento(3, 26139.6134),
            new Faturamento(4, 0.0),
            new Faturamento(5, 0.0),
            new Faturamento(6, 26742.6612),
            new Faturamento(7, 0.0),
            new Faturamento(8, 42889.2258),
            new Faturamento(9, 46251.174),
            new Faturamento(10, 11191.4722),
            new Faturamento(11, 0.0),
            new Faturamento(12, 0.0),
            new Faturamento(13, 3847.4823),
            new Faturamento(14, 373.7838),
            new Faturamento(15, 2659.7563),
            new Faturamento(16, 48924.2448),
            new Faturamento(17, 18419.2614),
            new Faturamento(18, 0.0),
            new Faturamento(19, 0.0),
            new Faturamento(20, 35240.1826),
            new Faturamento(21, 43829.1667),
            new Faturamento(22, 18235.6852),
            new Faturamento(23, 4355.0662),
            new Faturamento(24, 13327.1025),
            new Faturamento(25, 0.0),
            new Faturamento(26, 0.0),
            new Faturamento(27, 25681.8318),
            new Faturamento(28, 1718.1221),
            new Faturamento(29, 13220.495),
            new Faturamento(30, 8414.61)
        };

        double menor = double.MaxValue;
        double maior = double.MinValue;
        double soma = 0;
        int diasComFaturamento = 0;

        foreach (var f in faturamentos)
        {
            if (f.Valor > 0)
            {
                if (f.Valor < menor) menor = f.Valor;
                if (f.Valor > maior) maior = f.Valor;
                soma += f.Valor;
                diasComFaturamento++;
            }
        }

        if (diasComFaturamento > 0)
        {
            double media = soma / diasComFaturamento;
            int diasAcimaDaMedia = 0;

            foreach (var f in faturamentos)
            {
                if (f.Valor > media) diasAcimaDaMedia++;
            }

            Console.WriteLine($"Menor valor de faturamento: {menor}");
            Console.WriteLine($"Maior valor de faturamento: {maior}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
        }
        else
        {
            Console.WriteLine("Não há dias com faturamento válido (maior que zero).");
        }
    }

    class Faturamento
    {
        public int Dia { get; }
        public double Valor { get; }

        public Faturamento(int dia, double valor)
        {
            Dia = dia;
            Valor = valor;
        }
    }

    static void PercentualRepresentacao()
    {
        var faturamentoPorEstado = new Dictionary<string, double>
        {
            {"SP", 67836.43},
            {"RJ", 36678.66},
            {"MG", 29229.88},
            {"ES", 27165.48},
            {"Outros", 19849.53}
        };

        double total = 0;
        foreach (var estado in faturamentoPorEstado.Values)
        {
            total += estado;
        }

        foreach (var estado in faturamentoPorEstado)
        {
            double percentual = (estado.Value / total) * 100;
            Console.WriteLine($"{estado.Key} representa {percentual:F2}% do faturamento total.");
        }
    }

    static void InverterString()
    {
        Console.Write("Informe uma string para inverter: ");
        string texto = Console.ReadLine();
        char[] caracteres = new char[texto.Length];

        for (int i = 0; i < texto.Length; i++)
        {
            caracteres[i] = texto[texto.Length - 1 - i];
        }

        string invertido = new string(caracteres);
        Console.WriteLine($"String invertida: {invertido}");
    }
}
