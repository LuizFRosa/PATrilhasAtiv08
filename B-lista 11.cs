using System;

    class Program
    {
       
        public static int numerosC(string palavra)
        {
        	
        	return palavra.Length;
       
        }
      
        public static void Main(string[] args)
     {
           Console.WriteLine("Digite um texto ou palavra:");
           string resposta = Console.ReadLine();
           
           int quantidade = numerosC(resposta);
            
          Console.WriteLine("O número de caracteres são: " + quantidade);
          Console.WriteLine("Pressione qualquer botão para encerrar...");
          Console.ReadKey();
             
    }
}
