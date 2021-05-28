﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscrevendoCelular.ConsoleApp.Tela;

namespace EscrevendoCelular.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            TelaBase telaBase = new TelaBase();

            Console.Clear();

            while (true)
            {

                TelaBase tela = (TelaBase)telaBase.ObterTela();


                if (tela == null)
                {
                    break;
                }

                string opcao = tela.ObterOpcao();

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    continue;

                Console.Clear();

                if (opcao == "1")
                    tela.VisualizarFrase();

                Console.Clear();
            }

        }
    }
}
