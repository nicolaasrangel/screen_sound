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
            Dictionary<string, List<int>> BandasCadastradas = new Dictionary<string, List<int>>();
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
                    case 2: ListarBandasCadastradas();
                        break;
                    case 3: AvaliarBanda();
                        break;
                    case 4: ExibirMediaDasBandas();
                        break;
                    case 5:Environment.Exit(0);
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
                BandasCadastradas.Add(nomeDaBanda, new List<int>());
                Console.WriteLine($"Banda {nomeDaBanda} foi cadastrada com sucesso!");
                Thread.Sleep(1250);
                Console.Clear();
                MenuPrincipal();
            }

            void ListarBandasCadastradas()
            {
                Console.Clear();
                ExibirTituloDaOpcao("APRESENTAÇÃO DE TODAS AS BANDAS CADASTRADAS");
                
                foreach (string banda in BandasCadastradas.Keys)
                {
                    Console.WriteLine($"Banda: {banda}");
                }

                Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial");
                Console.ReadKey();
                Console.Clear();
                MenuPrincipal();
            }

            void AvaliarBanda()
            {
                //digite qual banda deseja avaliar
                // se a banda exitir no dicionario >> atribuir uma nota
                // senão, volta ao menu principal

                Console.Clear();
                ExibirTituloDaOpcao("CHEGOU A HORA DE DAR A NOTA A BANDA");
                Console.Write("Qual banda você quer avaliar? ");
                string nomeDaBanda = Console.ReadLine()!;

                if (BandasCadastradas.ContainsKey(nomeDaBanda))
                {
                    Console.Write($"Qual nota voçê acha que a banda {nomeDaBanda} merece? ");
                    int notaDaBanda = int.Parse(Console.ReadLine()!);
                    BandasCadastradas[nomeDaBanda].Add(notaDaBanda);
                    Console.WriteLine($"A nota {notaDaBanda} foi registrada com sucesso para a banda {nomeDaBanda}");
                    Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                } else
                {
                    Console.WriteLine("Sinto muito! a banda que voce informou não está cadastrada");
                    Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                }
            }

            void ExibirMediaDasBandas()
            {
                Console.Clear();
                ExibirTituloDaOpcao("EXIBIR MÉDIA DA BANDA");
                Console.Write("Qual a banda que deseja verificar a média? ");
                string nomeDaBanda = Console.ReadLine()!;
                
                if (BandasCadastradas.ContainsKey(nomeDaBanda))
                {
                    List<int> notasDaBanda = BandasCadastradas[nomeDaBanda];
                    Console.WriteLine($"A {nomeDaBanda} está com a média de {notasDaBanda.Average()}");
                    Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                } else
                {
                    Console.WriteLine("A banda que você digitou não consta no nosso sistema.");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                    MenuPrincipal();
                }
            }

            MenuPrincipal();
        }
    }
}
