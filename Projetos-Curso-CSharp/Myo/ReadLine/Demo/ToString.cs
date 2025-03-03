using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class ClassOne {
        public void Method() {

            Console.Write("Idade: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Sexo: ");
            char n2 = char.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            double n3 = double.Parse(Console.ReadLine(), C.I);

            Console.WriteLine("\nDigite o Nome, Sexo, Idade e Altura ");
            string[] vetor = Console.ReadLine().Split(' ');

            string nome = vetor[0];
            char sexo = char.Parse(vetor[1]);
            int idade = int.Parse(vetor[2]);
            double altura = double.Parse(vetor[3], C.I);

            Console.WriteLine("\nIdade: " + n1);
            Console.WriteLine("Sexo: " + n2);
            Console.WriteLine("Altura: " + n3.ToString("F2", CultureInfo.InvariantCulture) + "\n");

            Console.WriteLine("Nome: " + nome + "\nSexo: " + sexo + "\nIdade: " + idade + "\nAltura: " + altura.ToString("F2", C.I));

        }
    }
}

