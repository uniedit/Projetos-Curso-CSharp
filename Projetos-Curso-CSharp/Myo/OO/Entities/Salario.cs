using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projetos_Curso_CSharp.Myo {
    internal class Salario {

        public string Nome;
        public double SalarioFun;
        public double Media;

        public double Area(double salario1, double salario2) {
            return Media = (salario1 + salario2) / 2.0;
        }
    }
}
