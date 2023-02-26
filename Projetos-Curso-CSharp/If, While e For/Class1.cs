using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.While_e_If {
    public class Comparativas {
        internal class Class1 {
            public void Method1() {

                // OBS: Procedência do && maior que || e ! maior que todos
                // && <- E, || <- OU
                // ! <- NÃO (Nega uma expressão, ou a parte que ela está)            }

                Console.WriteLine("Entre com um número inteiro:");
                double c1 = double.Parse(Console.ReadLine());

                if (c1 % 2 == 0) {
                    Console.WriteLine("Par!");
                } else {
                    Console.WriteLine("Ímpar");
                }
            }
        }
    }
}
