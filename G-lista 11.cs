using System;

class Program
{
    static string CaracteresImpares(string input)
    {
        string resultado = "";
        
        for (int i = 1; i < input.Length; i += 2)
        {
            resultado += input[i];
        }
        
        return resultado;
    }

    public static void Main()
    {
        Console.WriteLine("Insira uma string:");
        string input = Console.ReadLine();
        
        string resultado = CaracteresImpares(input);
        
        Console.WriteLine("A string com caracteres nas posições ímpares é: " + resultado);
        Console.Writeline("Pressione qualquer botão para encerrar...");
        Console.ReadLine();
    }
}
