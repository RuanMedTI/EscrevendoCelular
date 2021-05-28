using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoCelular.ConsoleApp.Tela
{
    class TelaTeclado : TelaBase
    {
        override public string ObterOpcao()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Digite 1 para visualizar a conversão da letra");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite S para sair");
            Console.ResetColor();

            string opcao = Console.ReadLine();

            return opcao;
        }

        override public void VisualizarSMS()
        {

            try
            {
                Console.WriteLine("Digite uma letra para converter em números: ");
                fraseSms = Convert.ToString(Console.ReadLine().ToUpper());
            }

            catch
            {
                Console.WriteLine("Letra inválida!");
            }

            if (fraseSms == "A")
                Console.WriteLine("2");

            if (fraseSms == "B")
                Console.WriteLine("22");

            if (fraseSms == "C")
                Console.WriteLine("222");

            if (fraseSms == "D")
                Console.WriteLine("3");

            if (fraseSms == "E")
                Console.WriteLine("33");

            if (fraseSms == "F")
                Console.WriteLine("333");

            if (fraseSms == "G")
                Console.WriteLine("4");

            if (fraseSms == "H")
                Console.WriteLine("44");

            if (fraseSms == "I")
                Console.WriteLine("444");

            if (fraseSms == "J")
                Console.WriteLine("5");

            if (fraseSms == "K")
                Console.WriteLine("55");

            if (fraseSms == "L")
                Console.WriteLine("555");

            if (fraseSms == "M")
                Console.WriteLine("6");

            if (fraseSms == "N")
                Console.WriteLine("66");

            if (fraseSms == "O")
                Console.WriteLine("666");

            if (fraseSms == "P")
                Console.WriteLine("7");

            if (fraseSms == "Q")
                Console.WriteLine("77");

            if (fraseSms == "R")
                Console.WriteLine("777");

            if (fraseSms == "S")
                Console.WriteLine("7777");

            if (fraseSms == "T")
                Console.WriteLine("8");

            if (fraseSms == "U")
                Console.WriteLine("88");

            if (fraseSms == "V")
                Console.WriteLine("888");

            if (fraseSms == "W")
                Console.WriteLine("9");

            if (fraseSms == "X")
                Console.WriteLine("99");

            if (fraseSms == "Y")
                Console.WriteLine("999");

            if (fraseSms == "Z")
                Console.WriteLine("9999");

            if (fraseSms == " ")
                Console.WriteLine("_");

            Console.ReadLine();
        }

    }
}
