using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            // Consultar Tabelas-Verdade de cada Tipo de Operador em caso de dúvida
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            bool comprouTv50  = executouTrabalho1 && executouTrabalho2; // Operador &&(E/AND)
            Console.WriteLine("Comprou a Tv 50? {0}", comprouTv50);

            var comprouSorvete = executouTrabalho1 || executouTrabalho2; // Operador ||(OR)
            Console.WriteLine("Comprou sorvete? {0}", comprouSorvete);

            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2; // Operador ^ (XOR)
            Console.WriteLine("Comprou a Tv de 32? {0}", comprouTv32);

            Console.WriteLine("Mais saudável? {0}", !comprouSorvete); // Negação lógica

            
        }
    }
}
