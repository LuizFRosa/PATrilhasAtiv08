using System;
using System.Collections.Generic;

    class Program
    {
       
        static List<int> FiltrarPares(List<int> numeros)
        {
            List<int> pares = new List<int>();

            foreach (int numero in numeros)
            {
                if (numero % 2 == 0) 
                {
                    pares.Add(numero); 
                }
            }
            return pares;
        }

        public static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

            List<int> pares = FiltrarPares(numeros); 
  
            Console.WriteLine("Números pares: " + string.Join(", ", pares));
            Console.WriteLine("Pressione qualquer botão para encerrar...");
            Console.ReadKey();
        }
    }
