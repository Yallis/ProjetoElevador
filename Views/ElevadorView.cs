using ProjetoElevador.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Views {
    internal class ElevadorView {

        // função que imprime o elevador e os andares no console
        public void ExibirAndares(int _andares, int _andarAtual, int _pessoas) {
            Console.Clear();

            // imprime o teto do edifício
            Console.WriteLine("\n\t_________________");

            for (int i = _andares; i >= 0; i--) {

                // se for o andar atual, imprime o elevador no andar com o número de pessoas dentro dele
                if(i == _andarAtual) {
                    Console.WriteLine("\t|____|          |");
                    // imprime o numero do andar e um espaço extra se tiver apenas um dígito
                    if (i < 10) Console.Write("\t|      ");
                    else Console.Write("\t|     ");
                    // imprime o número do andar ou 'T' se for 0
                    if(i == 0) Console.WriteLine("T        |");
                    else Console.WriteLine($"{i}        |");

                    // imprime o numero de pessoas no elevador e um espaço extra se tiver apenas um digíto
                    if(_pessoas < 10) Console.WriteLine($"\t|__{_pessoas}____________|");
                    else Console.WriteLine($"\t|_{_pessoas}____________|");
                }
                else {
                    Console.WriteLine("\t|    |          |");
                    // imprime o numero do andar e um espaço extra se tiver apenas um dígito
                    if (i < 10)
                        Console.Write("\t|    | ");
                    else Console.Write("\t|    |");
                    // imprime o número do andar ou 'T' se for 0
                    if (i == 0) {
                        Console.WriteLine("T        |");
                        Console.WriteLine("\t|____|__________|");
                    }
                    else {
                        Console.WriteLine($"{i}        |");
                        Console.WriteLine("\t|    |__________|");
                    }
                }
            }
        }


        // função que exibe as opções e aguarda a escolha do usuário
        public void ExibirMenu() {
            Console.WriteLine();
            Console.WriteLine(@" Escolha uma opção:
    1. Entrar
    2. Sair
    3. Subir
    4. Descer
    5. Encerrar
    ");
        }

        // função que exibe mensagens de aviso ao usuário
        public void ExibirMensagem(int opcao) {
            switch (opcao) {
                case 1:
                    Console.WriteLine("A capacidade do elevador foi atingida. Não é possível que mais pessoas entrem no elevador.\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("O elevador está vazio. Não é possível que mais pessoas saiam do elevador.\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("O elevador está no último andar. Não é possível subir mais.\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("O elevador está no terreo. Não é possível descer mais.\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
                case 8:
                    Console.WriteLine("A capacidade do elevador deve ser de pelo menos 1 pessoa. Tente novamente.\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case 9:
                    Console.WriteLine("A número de andares deve ser de pelo menos 1 andar. Tente novamente.\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                default: Console.WriteLine("Opção inválida. É preciso escolher por umas das alternativas exibidas.\nPressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
