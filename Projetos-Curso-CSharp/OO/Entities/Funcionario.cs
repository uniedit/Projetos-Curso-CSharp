using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.OO.Entities {
    internal class Funcionario {

        public string Name;
        public double Salario;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalarioPonto(double porcentagem) {
            SalarioBruto += (porcentagem / 100.00) * SalarioBruto;
        }

        public override string ToString() {
            return Name + ", " + SalarioLiquido().ToString("F2", C.I);
        }

    }
}
