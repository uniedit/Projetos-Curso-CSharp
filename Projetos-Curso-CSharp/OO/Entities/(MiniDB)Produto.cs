using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.OO.Entities {
    internal class Produto {

        public string Nome;
        public double Preco;
        public int Quantidade;

        // Criar uma variavel que retorna valor
        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        // Operação padrão para modificar valor existente (VOID)
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        // Usar ToString para formatar textos
        // override ToString
        public override string ToString() {
            return Nome
                + ", $ "
                + Preco.ToString("F2", C.I)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", C.I);
        }

    }
}
