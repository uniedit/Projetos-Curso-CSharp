using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo {
    internal class Class6 {
        public void Method() {

            double[,] mat = new double[2, 3];

            // 6
            Console.WriteLine(mat.Length);

            // 2
            Console.WriteLine(mat.Rank);

            // 2
            Console.WriteLine(mat.GetLength(0));

            // 3
            Console.WriteLine(mat.GetLength(1));

        }
    }
}
