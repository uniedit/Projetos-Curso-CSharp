using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo {
    internal class Class3 {
        public void Method() {

            string[] vect = new string[] { "oi", "nao" };

            foreach (string obj in vect) {
                Console.WriteLine(obj);
            }
        }
    }
}

