using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1215;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            // Valores inteiros com capacidades de memória diferentes

            byte idade = 45;
            Console.WriteLine("Idade" + idade); // Sem sinal

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols "+ saldoDeGols); // Com sinal

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue; // Mais usado dos inteiros, com sinal
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileiro = 207_600_000; // Sem sinal
            Console.WriteLine("População Brasileira " + populacaoBrasileiro);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong); // Com sinal

            ulong populacaoMundial = 7_888_888;
            Console.WriteLine("População Mundial " + populacaoMundial); // Sem sinal

            float precoComputador = 1299.99f; // É um double com menos capacidade, deve add um F ou f
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaApple = 10_000_000_000.00; // Mais usado dos reais
            Console.WriteLine("Valor mercado da Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja Bem Vindo ao Curso C#!";
            Console.WriteLine(texto);




        }
    }
}
