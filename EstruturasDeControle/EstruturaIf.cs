using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            // Var
            string entrada;
            bool bomComportamento = false;

            // Inicio
            Console.Write("Nota do Aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("Possui um bom comportamento? |s| |n|: ");
            entrada = Console.ReadLine();

            // if (entrada == "S" || entrada == "S")
            //    bomComportamento = true;
            
            // bomComportamento = entrada.toLower() == "s";
            
            bomComportamento = entrada == "S" || entrada == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro De Honra!");
            } 

        }
    }
}
