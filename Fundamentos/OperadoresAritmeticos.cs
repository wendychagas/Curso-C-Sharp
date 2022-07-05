using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000;
            var imposto = 455;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine("O preço final é {0}",
                totalComDesconto);

            // IMC
            double peso = 58.8;
            double altura = 1.68;
            double imc = peso / (altura * altura);
            Console.WriteLine("IMC = {0}", imc);
            // Método 1 para altura ao quadrado

            double peso2 = 91.2;
            double altura2 = 1.82;
            double imc2 = peso2 / Math.Pow(altura2, 2);
            Console.WriteLine("IMC 2 = {0}", imc2);
            // Método 2 para potenciação

            // Número Par/Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

            int test = 27;
            Console.WriteLine("valor de 27 + 27 = {0}", test + test);


        }
    }
}
