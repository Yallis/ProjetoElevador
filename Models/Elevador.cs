using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Model {
    internal class Elevador {

        int andarAtual         = 0;
        int totalAndares       = 1;
        int capacidadeElevador = 1;
        int pessoasABordo      = 0;

        // função que define a capacidade e o total de andares do elevador
        public void Inicializar(int _capacidadeTotal, int _andaresTotal) {
            andarAtual = 0;
            totalAndares = _andaresTotal;
            capacidadeElevador = _capacidadeTotal;
            pessoasABordo = 0;
        }

        // função que acrescenta um passageiro ao elevador e retorna TRUE se a operação for bem sucedida
        public bool Entrar() {
            if (pessoasABordo < capacidadeElevador) {
                pessoasABordo++;
                return true;
            }
            else return false;
        }

        // função que remove um passageiro do elevador e retorna TRUE se a operação for bem sucedida
        public bool Sair() {
            if (pessoasABordo > 0) {
                pessoasABordo--;
                return true;
            }
            else return false;
        }

        // função que faz o elevador subir e retorna TRUE se a operação for bem sucedida
        public bool Subir() {
            if (andarAtual < totalAndares) {
                andarAtual++;
                return true;
            }
            else return false;
        }

        // função que faz o elevador descer e retorna TRUE se a operação for bem sucedida
        public bool Descer() {
            if (andarAtual > 0) {
                andarAtual--;
                return true;
            }
            else return false;
        }

        public int AndarAtual { get { return andarAtual; } }
        public int TotalAndares { get { return totalAndares; } }
        public int CapacidadeElevador { get { return capacidadeElevador; } }
        public int PessoasABordo { get { return pessoasABordo; } }

    }
}
