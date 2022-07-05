using System;

namespace CursoCSharp.Fundamentos
{
    class PrimeiroPrograma
    {
        public static void Executar()
        {
            {
                Console.WriteLine("-----------------");
                Console.WriteLine("Primeiro Programa");
                Console.Write("Escreva um número: ");
                int.TryParse(Console.ReadLine(), out int num);
                Console.WriteLine("Seu número: " + num);
                Console.WriteLine("Terminou.");
                Console.WriteLine("-----------------");
            }
            
            
        }
    }
}
