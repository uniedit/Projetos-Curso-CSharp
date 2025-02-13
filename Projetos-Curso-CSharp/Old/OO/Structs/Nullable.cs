using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Structs {
    public class Classe {
        internal class Class {
            public void Method() {

                double? x = null;  // Variavel null
                double? y = 10.0;

                double a = x ?? 5;  // Se x for nullo, vai valer o valor do lado (5)
                double b = y ?? 5;  // y não é nullo então (y = 10.0)

                Console.WriteLine(x.GetValueOrDefault());  // Pega o valor ou se for nullo, define como o padrão (double == 0.0)
                Console.WriteLine(y.GetValueOrDefault());

                Console.WriteLine(x.HasValue);  // Se possui valor (null == false)
                Console.WriteLine(y.HasValue);

                if (x.HasValue) {
                    Console.WriteLine(x.Value);
                } else {
                    Console.WriteLine("X is null");
                }

                if (y.HasValue) {
                    Console.WriteLine(y.Value);
                } else {
                    Console.WriteLine("Y is null");
                }

            }
        }
    }
}
