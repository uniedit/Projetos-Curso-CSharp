using Projetos_Curso_CSharp.OO.Structs.Ref_e_Out.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.OO.Structs.Ref_e_Out {
    public class Classe {
        internal class Class {
            public void Method() {

                int a = 5;
                Ref.Triplo(ref a);  // Referncia "a" apontando para "x" fazendo a operação em "Ref.Triplo"
                Console.WriteLine(a);

            }
        }
    }
}
