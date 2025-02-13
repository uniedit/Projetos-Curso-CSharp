using Projetos_Curso_CSharp.OO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe22 {
        internal class Class1 {
            public void Method2() {

                Funcionario x = new Funcionario();

                Console.Write("Nome: ");
                x.Name = Console.ReadLine();

                Console.Write("Salário bruto: ");
                x.SalarioBruto = double.Parse(Console.ReadLine(), C.I);

                Console.Write("Imposto: ");
                x.Imposto = double.Parse(Console.ReadLine(), C.I);
                Console.WriteLine();

                Console.Write($"Funcionário: {x}\n\n");

                Console.Write("Digite a porcentagem para aumentar o salário: ");
                double Aumentar = double.Parse(Console.ReadLine(), C.I);
                x.AumentarSalario(Aumentar);
                Console.WriteLine();

                Console.WriteLine($"Dados atualizados: {x}");

            }
        }
    }
}