using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe {
        internal class Class1 {
            public void Method() {

                string[] vetor = Console.ReadLine().Split(' ');

                double v1 = double.Parse(vetor[0]);
                double v2 = double.Parse(vetor[1]);

                while (v1 != 0 && v2 != 0) {

                    if (v1 > 0 && v2 > 0) {
                        Console.WriteLine("Primeiro quadrante");
                    } else if (v1 > 0 && v2 < 0) {
                        Console.WriteLine("Quarto quadrante");
                    } else if (v1 < 0 && v2 < 0) {
                        Console.WriteLine("Terceiro quadrante");
                    } else {
                        Console.WriteLine("Segundo quadrante");
                    }

                    // Reler vetores
                    vetor = Console.ReadLine().Split(' ');

                    v1 = double.Parse(vetor[0]);
                    v2 = double.Parse(vetor[1]);
                }
            }
        }
    }
}
