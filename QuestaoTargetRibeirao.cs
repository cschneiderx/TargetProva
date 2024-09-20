using System;

class Program
{
    static void Main()
    {
        // 1) Verificar se um número pertence à sequência de Fibonacci
        // ===========================================================================
        Console.WriteLine("Questão 1: Verificar se um número pertence à sequência de Fibonacci");
        Console.Write("Informe um número: ");
        int numero = int.Parse(Console.ReadLine());
        if (PertenceFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
        }
        Console.WriteLine();

        // 2) Verificar a existência e contar a quantidade de 'a' em uma string
        // ===========================================================================
        Console.WriteLine("Questão 2: Verificar a existência da letra 'a' em uma string");
        Console.Write("Informe uma string: ");
        string entrada = Console.ReadLine();
        int contagem = ContarLetraA(entrada);

        Console.WriteLine($"A letra 'a' aparece {contagem} vezes na string.");
        Console.WriteLine();

        // 3) Valor final da variável SOMA
        // ===========================================================================
        // Questão 3: int INDICE = 12, SOMA = 0, K = 1;
        // Enquanto K < INDICE faça {
        //   K = K + 1;
        //   SOMA = SOMA + K;
        // }
        // imprimir(SOMA);
        // Resposta: O valor final de SOMA será 78.
        int INDICE = 12, SOMA = 0, K = 1;

        while (K < INDICE)
        {
            K = K + 1;
            SOMA = SOMA + K;
        }

        Console.WriteLine("Questão 3: Valor final de SOMA = " + SOMA);
        Console.WriteLine();

        // 4) Completar a sequência lógica
        // ===========================================================================
        // Questão 4:
        // a) 1, 3, 5, 7, ___
        // Resposta: 9 (sequência de números ímpares consecutivos)
        
        // b) 2, 4, 8, 16, 32, 64, ____
        // Resposta: 128 (cada termo é o dobro do anterior)
        
        // c) 0, 1, 4, 9, 16, 25, 36, ____
        // Resposta: 49 (sequência dos quadrados perfeitos: 0², 1², 2², 3², 4², 5², 6², 7²)
        
        // d) 4, 16, 36, 64, ____
        // Resposta: 100 (sequência dos quadrados de números pares: 2², 4², 6², 8², 10²)
        
        // e) 1, 1, 2, 3, 5, 8, ____
        // Resposta: 13 (sequência de Fibonacci)
        
        // f) 2, 10, 12, 16, 17, 18, 19, ____
        // Resposta: 20 (sequência de números que começam com a letra 'd' em inglês: two, ten, twelve, sixteen, seventeen, eighteen, nineteen, twenty)

        // 5) Problema dos interruptores e lâmpadas
        // ===========================================================================
        // Questão 5: Como descobrir qual interruptor controla qual lâmpada?
        // Resposta: 
        // 1. Ligue o primeiro interruptor e deixe ligado por alguns minutos.
        // 2. Desligue o primeiro interruptor e ligue o segundo interruptor.
        // 3. Vá até a sala das lâmpadas:
        // - Lâmpada acesa: Está conectada ao segundo interruptor (que ainda está ligado).
        // - Lâmpada quente e apagada: Está conectada ao primeiro interruptor (que estava ligado e foi desligado).
        // - Lâmpada fria e apagada: Está conectada ao terceiro interruptor (que não foi ligado).

        // Métodos auxiliares
        // ===========================================================================
    }

    // Método para verificar se um número pertence à sequência de Fibonacci
    static bool PertenceFibonacci(int num)
    {
        if (num < 0) return false;

        int a = 0, b = 1, c = 0;

        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c == num || num == 0;
    }

    // Método para contar a quantidade de letras 'a' em uma string
    static int ContarLetraA(string texto)
    {
        int contador = 0;
        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }
        return contador;
    }
}
