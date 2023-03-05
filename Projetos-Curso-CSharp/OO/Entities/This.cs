using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.OO.Entities {
    internal class This {

        public string Nome1;
        public double Preco1;
        public int Quantidade1;

        public This() {
            Quantidade1 = 10;
        }

        // This referencia um outro construtor, no caso o padrão defenido como () apenas
        public This(string nome1, double preco1) : this() {
            Nome1 = nome1;
            Preco1 = preco1;
        }

        // Neste caso referencia o construtor de dois argumentos acima
        public This(string nome1, double preco1, int quantidade1) : this(nome1, preco1) {
            Quantidade1 = quantidade1;
        }
    }
}
