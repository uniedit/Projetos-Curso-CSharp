using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.OO.Entities {
    internal class ConversorStatic {

        public static double Cotação;
        public static double IOF = 0.06;

        public static double Conversor(double dolar) {
            double R = Cotação * dolar;
            return R * IOF + R;
        }
    }
}
