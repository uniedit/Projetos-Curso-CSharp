using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Myo.OO.Structs {
    internal class Class {
        public void Method() {

            Point p;
            p.X = 10;
            p.Y = 5;
            // Resultado: (10,5)
            Console.WriteLine(p);

            p = new Point();
            // Resultado: (0,0)
            Console.WriteLine(p);

        }
    }
}
