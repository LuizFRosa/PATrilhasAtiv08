using System;
using System.Collections.Generic;

class Program
{
    static double CalcularMedia(List<int> numeros)
    {
        if (numeros.Count == 0)  
        {
            return 0;  
        }

        int soma = 0;

        foreach (int numero in numeros)
        {
            soma += numero;
        }

        double media = (double)soma / numeros.Count;
        return media;
    }

    public static void Main()
    {
        List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };

        double media = CalcularMedia(numeros);
        Console.WriteLine("A média dos números é: " + media);

        Console.Writeline("Pressione qualquer botão para encerrar...");
        Console.ReadKey();
    }
}
