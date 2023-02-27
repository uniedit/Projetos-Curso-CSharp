using Projetos_Curso_CSharp.OO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe4 {
        internal class Class1 {
            public void Method() {

                Funcionario x, y;
                x = new Funcionario();
                y = new Funcionario();

                Console.WriteLine("Dados do primeiro funcionário:");
                Console.Write("Nome: ");
                x.Name = Console.ReadLine();
                Console.Write("Salário: ");
                x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Dados do segundo funcionário: ");
                Console.Write("Nome: ");
                y.Name = Console.ReadLine();
                Console.Write("Salário: ");
                y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double SalárioMédio = (x.Salario + y.Salario) / 2.0;

                Console.WriteLine($"Salário médio = {SalárioMédio.ToString("F2", CultureInfo.InvariantCulture)}");

            }
        }
    }
}