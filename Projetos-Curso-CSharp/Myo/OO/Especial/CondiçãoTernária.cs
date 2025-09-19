using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class CondiçãoTernária {
        public void Method() {

            // ( condição ) ? valor_se_verdadeiro : valor_se_falso
            // ( 2 > 4 ) ? 50 : 80 -> 80
            // ( 10 != 3 ) ? "Maria" : "Alex" - > "Maria"

            /*
            double preco = 34.5;
            double desconto;

            if (preco < 20.0) {
                desconto = preco * 0.1;
            } else {
                desconto = preco * 0.05;
            }
            */

            double preco = 34.5;

            // Sendo a mesma coisa que o if e else ele faz a mesma verificação com os dois valores, caso falso, caso verdadeira.
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

        }
    }
}

