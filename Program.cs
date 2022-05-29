using ProjetoElevador.Model;
using ProjetoElevador.Views;
using System;

namespace ProjetoElevador {
    internal class Program {
        static void Main(string[] args) {


            ElevadorView elevadorView = new ElevadorView();
            Elevador elevador = new Elevador();

            int _capacidadeTotal, _andaresTotal;

            // pede um valor para a capacidade total até que um valor válido seja digitado
            bool valido = false;
            do {
                Console.Clear();
                Console.WriteLine("Qual deve ser a capacidade total de pessoas no elevador?");
                _capacidadeTotal = LerOpcao();

                // trata se foi digitada uma capacidade válida
                if (_capacidadeTotal > 0)
                    valido = true;
                else {
                    elevadorView.ExibirMensagem(8);
                }
            } while (!valido);

            // pede um valor para o total de andares até que um valor válido seja digitado
            valido = false;
            do {
                Console.Clear();
                Console.WriteLine("Qual deve ser o total de andares do elevador?");
                _andaresTotal = LerOpcao();

                // trata se foi digitado um número de andares válido
                if (_andaresTotal > 0)
                    valido = true;
                else {
                    elevadorView.ExibirMensagem(9);
                }
            } while (!valido);

            // inicializa os valores para a capacidade total do elevador e o total de andares
            elevador.Inicializar(_capacidadeTotal, _andaresTotal);

            bool continuar = true;
            int opcaoEscolhida;

            // executa o programa conforme a opção escolhida até que seja escolhido "Encerrar"
            do {
                elevadorView.ExibirAndares(elevador.TotalAndares, elevador.AndarAtual, elevador.PessoasABordo);
                elevadorView.ExibirMenu();
                opcaoEscolhida = LerOpcao();

                switch (opcaoEscolhida) {
                    case 1: if (!elevador.Entrar())
                                elevadorView.ExibirMensagem(opcaoEscolhida);
                            break;
                    case 2: if(!elevador.Sair())
                                elevadorView.ExibirMensagem(opcaoEscolhida);
                            break;
                    case 3: if (!elevador.Subir())
                                elevadorView.ExibirMensagem(opcaoEscolhida);
                            break;
                    case 4: if(!elevador.Descer())
                                elevadorView.ExibirMensagem(opcaoEscolhida);
                            break;
                    case 5: continuar = false; break;
                    default: elevadorView.ExibirMensagem(opcaoEscolhida); break;
                }
            } while (continuar);

            // funcao para ler e tratar se o que foi digitado é válido
            int LerOpcao() {
                string opcaoEscolhida = Console.ReadLine();

                int _opcaoEscolhida;
                if (int.TryParse(opcaoEscolhida, out _opcaoEscolhida))
                    return _opcaoEscolhida;
                else return -1;
            }
        }

        
    }
}
