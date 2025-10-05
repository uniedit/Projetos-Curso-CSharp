using System.Globalization;

namespace Projetos_Curso_CSharp.Myo {
    internal class Estoque {

        // Padrã usado para variaveis privadas :v
        private string _nome;
        private int _quantidade;
        // Exemplo de manipulação da variavel com autoproperties (deixando-o private)
        // No caso é possivel perceber que o mesmo fica inacessivel para manipulação em outra classe
        public double Preco { get; private set; }

        // Construtor aceitando 3 argumentos, podendo ser até podificado usando o .this
        public Estoque(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Referencia de código o qual necessita de uma logica no set por exemplo
        public string Nome {
            get { return _nome; }
            set {
                // Value tem como objetivo pegar a entrada do metodo set e funcionar como um parametro de entrada.
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public int Quantidade {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        // Metodo override para impressão da classe "Estoque" usando metodo ToString
        public override string ToString() {
            return $"Dados Atualizados: {_nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {_quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}