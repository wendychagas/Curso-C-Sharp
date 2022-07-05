using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5976.00;

            Console.WriteLine("O " + nome + " da marca "  // Método 1
                + marca + " custa " + preco + " .");
            
            Console.WriteLine("O {0} da marca {1} custa {2}.",
                nome, marca, preco); // Método 2
            Console.WriteLine($"O {nome} da marca {marca} custa {preco}"); // Método 3
            Console.WriteLine($"A marca {marca} é legal!");
            Console.WriteLine($"1 + 1 = {1+1}!");
        }
    }
}
