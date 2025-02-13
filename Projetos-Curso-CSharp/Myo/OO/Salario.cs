using Projetos_Curso_CSharp.Myo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class ClassTwo {
        public void Method() {

            Salario salario1, salario2;
            salario1 = new Salario();
            salario2 = new Salario();

            Console.WriteLine($"Dados do primeiro funcionário:");
            Console.Write($"Nome: ");
            salario1.Nome = Console.ReadLine();

            Console.Write($"Salário: ");
            salario1.SalarioFun = double.Parse(Console.ReadLine(), C.I);

            Console.WriteLine($"Dados do segundo funcionário:");
            Console.Write($"Nome: ");
            salario2.Nome = Console.ReadLine();

            Console.Write($"Salário: ");
            salario2.SalarioFun = double.Parse(Console.ReadLine(), C.I);

            double media = salario1.Area(salario1.SalarioFun, salario2.SalarioFun);

            Console.WriteLine($"Salário Médio = {media}");

        }
    }
}

