using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo {
    internal class Class7 {
        public void Method() {

            Console.Write("Digite o tamanho N da Matriz: ");
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];
            int neg = 0;

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, i] + " ");
                Console.WriteLine();
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] < 0) {
                        neg++;
                    }
                }
            }

            Console.WriteLine($"Negative Numbers = {neg}");

        }
    }
}
