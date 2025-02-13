using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.OO.Structs.Ref_e_Out.Entities {
    class Ref {

        public static void Triplo(ref int x) {  // Operação usando um atributo x * 3
            x = x * 3;
        }

    }
}
