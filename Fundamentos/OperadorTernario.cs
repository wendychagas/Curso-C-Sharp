﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    class OperadorTernario
    {
        public static void Executar()
        {
            var nota = 6.0;
            bool bomComportamento = true;
            string resultado = nota >= 7.0 && bomComportamento
                ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
