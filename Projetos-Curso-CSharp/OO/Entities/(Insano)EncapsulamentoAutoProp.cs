using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.OO.Entities {
    internal class EncapsulamentoAutoProp {

        private string _nome; // <<- Caso possua logica não é possivel a implementação de set
        public double Preco { get; private set; }  // Metodo autoProperties
        public double Quantidade { get; private set; }

        public EncapsulamentoAutoProp() {
        }

        public EncapsulamentoAutoProp(string nome, double preco, double quantidade) {
            _nome = nome;  
            Preco = preco;
            Quantidade = quantidade;
        }
    }
}
