using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoCelular.ConsoleApp.Tela
{
    class TelaBase
    {

        public static TelaTeclado telaTeclado = new TelaTeclado();

        public string fraseSms;

        public virtual object ObterTela()
        {
            string opcao = "";
            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Escrevendo no Celular 1.1");
                Console.WriteLine("--------------------------------");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Digite 1 para visualizar a conversão");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite S para Sair");
                Console.ResetColor();

                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    TelaTeclado tela = telaTeclado;
                    return tela;
                }

            } while (OpcaoInvalida(opcao));

            return null;
        }

        private bool OpcaoInvalida(string opcao)
        {
            if (opcao == "s" || opcao == "S" || opcao == "1")
            {
                return false;
            }
            return true;
        }

        public virtual string ObterOpcao()
        {
            return "";
        }

        public virtual void VisualizarSMS()
        {
        }

    }
}
