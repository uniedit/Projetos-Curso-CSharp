using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Conversão_Casting {
    public class Classe {
        internal class Class1 {
            public void Method() {

                Console.WriteLine("Digite três números:");

                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int n3 = int.Parse(Console.ReadLine());

                double R = Maior(n1, n2, n3);

                Console.WriteLine($"Maior = {R}");
            }

            static int Maior(int a, int b, int c) {

                int M;

                if (a > b && a > c) {
                    M = a;
                } else if (b > c) {
                    M = b;
                } else {
                    M = c;
                }
                return M;
            }
        }
    }
}