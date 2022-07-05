using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.###"));
            // ToString converte em string
            // Entre parenteses é o método do comando
            // F1(F2, F3...) = quantidade casa decimal
            // C = valor monetário
            // P Percentual
            // #.## = F3, #.## = F2, ...

            CultureInfo cultura = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));
            Console.WriteLine(valor.ToString("C2", cultura));
            // Alterando moeda padrão do sistema
            // C0 = sem casas decimais, posso C1, C2...

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
            // D(x) = Quantidade de zeros à direita
            // Não é possível adicionar zeros a direita escrevendo
            // na linha do codigo.

        }
    }
}
