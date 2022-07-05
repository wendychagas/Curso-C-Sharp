using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3; // valor inicial 
            num1 = 7; // mudança de valor
            num1 += 10; // num1 = 7 + 10; (atribuição valor)
            num1 -= 3; // num1 = 17 - 3;
            num1 *= 5; // num1 = 14 * 5;
            num1 /= 2; // num1 = 70 / 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // a = a + 1;
            b--; // b = b - 1;

            Console.WriteLine($"{a} e {b}");
        }
    }
}
