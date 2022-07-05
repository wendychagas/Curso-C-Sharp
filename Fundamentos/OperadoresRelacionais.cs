using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            Console.Write("Digite a nota: ");
            // double nota = 6.0; comentada por que queria colocar x nota pelo console
            double.TryParse(Console.ReadLine(), out double nota); // Variavel nota tipo double funçao try parse para ler o numero digitado no console
            double notaCorte = 7.0;
            Console.WriteLine("Nota inválida? {0}", nota > 10.0); // Maior que
            Console.WriteLine("Nota inválida? {0}", nota < 0.0); // Menor que
            Console.WriteLine("Perfeito? {0}", nota == 10.0); // Igual que
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0); // Diferente de
            Console.WriteLine("Passou por média? {0}", nota >= notaCorte); // Maior ou igual
            Console.WriteLine("Recuperação? {0}", nota < notaCorte);  // Menor que
            Console.WriteLine("Reprovado? {0}", nota <= 3.0); // Menor igual


        }
    }
}
