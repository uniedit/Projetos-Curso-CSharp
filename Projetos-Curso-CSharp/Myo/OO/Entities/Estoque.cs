using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projetos_Curso_CSharp.Myo {
    internal class Estoque {

        public static string Nome;
        public static double Preco;
        public static int Quantidade;

        public static double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public static void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public static void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public new static string ToString() { 
            return $"Dados Atualizados: {Nome}, $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: $ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
