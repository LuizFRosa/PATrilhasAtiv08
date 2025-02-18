using System;

class Program
{
    static bool VerificarPar(int numero)
    {
        return numero % 2 == 0; 
    }

    public static void Main()
    {
        Console.WriteLine("Insira um número:");
        int num = int.Parse(Console.ReadLine());
        
        bool resultado = VerificarPar(num);
        
        if (resultado)
        {
            Console.WriteLine("O número {0} é par.", num);
        }
        else
        {
            Console.WriteLine("O número {0} é ímpar.", num);
        }
        Console.WriteLine("Pressione qualquer botão para encerrar...");
        Console.ReadLine();
    }
}
