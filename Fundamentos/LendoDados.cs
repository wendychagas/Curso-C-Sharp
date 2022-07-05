﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());
            // int.Parse transformou a leitura do numeral em textual
            // Ex: "1" => 1

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"{nome} {idade} R${salario}");


        }
    }
}


