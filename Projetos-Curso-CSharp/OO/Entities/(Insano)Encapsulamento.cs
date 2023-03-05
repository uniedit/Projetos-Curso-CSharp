using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.OO.Entities {
    internal class Encapsulamento {

        // OBS: Padrão usar "_nomeEmMinusculo" caso estiver private
        private string _nome;
        private double _preco;
        private int _quantidade;

        // Construtor de 3 parametros recebendo 3 variaveis
        public Encapsulamento(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // Contrutor Get retornando apenas o nome
        // Vantagens: Possivel adicionar logica, tal como if
        public string GetNome() {
            return _nome;
        }

        // Void pois modifica _nome
        // Construtor de modificação ^^
        public void SetNome(string nome) {
            _nome = nome;
        }

        // Apenas usando Get ^^
        public double GetPreco() {
            return _preco;
        }

        // OBS: caso não queira que seja modificado, apenas use o Get 


        // ============================================================================================= //


        // Properties e Value ^^
        public string Nome { //"Nome" é o valor que vai ser importado, tal como (x.Nome)
            get { return _nome; } // Metodo Get
            set { _nome = value; } // Como set é o metodo de modificar uma variavel, ela precisa receber-la com a palavra "value"
        }

        // OBS: É possivel adicionar logica no set também
        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }

        }

        public double ValorTotalEmEstoque {
            get { return Preco * Quantidade; }
        }

    }
}
