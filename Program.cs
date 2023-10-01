using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    class Program
    {
        public static void Main(string[] args)
        {
            string apresentacao = "Olá! Seja Bem Vindo ao Screen Sound.";

            void ExibirLogo()
            {
                Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");

                Console.WriteLine(apresentacao);

            }

            void MenuPrincipal()
            {
                ExibirLogo();
                Console.WriteLine("\nDigite 1 para cadastrar uma banda");
                Console.WriteLine("Digite 2 para apresentar as bandas cadastradas");
                Console.WriteLine("Digite 3 para avaliar uma banda cadastrada");
                Console.WriteLine("Digite 4 para exibir a média da banda");
                Console.WriteLine("Digite 5 para sair");

                Console.Write("\nEscolha a opção: ");
                int opcao = int.Parse(Console.ReadLine()!);

                switch (opcao)
                {
                    case 1: CadastroDeBandas();
                        break;
                    case 2: Console.WriteLine();
                        break;
                    case 3: Console.WriteLine();
                        break;
                    case 4: Console.WriteLine();
                        break;
                    case 5: Console.WriteLine();
                        break;
                    default: Console.WriteLine("Opção invalida!");
                        break;
                }
            }

            void ExibirTituloDaOpcao(string titulo)
            {
                int numeroDeCaratcteres = titulo.Length;
                string asteriscos = string.Empty.PadLeft(numeroDeCaratcteres, '*');
                Console.WriteLine(asteriscos);
                Console.WriteLine(titulo);
                Console.WriteLine(asteriscos);
            }

            void CadastroDeBandas()
            {
                Console.Clear();
                ExibirTituloDaOpcao("CADASTRO DE BANDAS");
                Console.Write("\nDigite o nome da banda que deseja cadastrar: ");
                string nomeDaBanda = Console.ReadLine()!;

            }

            MenuPrincipal();
        }
    }
}
