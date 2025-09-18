using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo {
    internal class Class8 {
        public void Method() {

            Console.WriteLine("Entre dois Valores: ");

            string[] value = Console.ReadLine().Split(' ');

            int row = int.Parse(value[0]);
            int colum = int.Parse(value[1]);

            int[,] mat = new int[row, colum];

            for (int i = 0; i < row; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < colum; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            int index = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++) {
                for (int j = 0; j < colum; j++) {
                    if (mat[i, j] == index) {
                        Console.WriteLine($"Position: {i}, {j}");

                        if (j > 0) {
                            int left = mat[i, j - 1];
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }

                        if (j < colum - 1) {
                            int right = mat[i, j + 1];
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }

                        if (i > 0) {
                            int up = mat[i - 1, j];
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }

                        if (i < row - 1) {
                            int down = mat[i + 1, j];
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }

                    }
                }
            }

        }
    }
}
