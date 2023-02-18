using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados
{
    public class Classe2
    {
        internal class Class1
        {
            public void Method()
            {
                int n1 = int.Parse(Console.ReadLine());
                char ch = char.Parse(Console.ReadLine());
                double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // Consegue ler qualquer variavel, sendo String, double, char etc
                string[] vetor = Console.ReadLine().Split(' ');

                // Formatação padrão para ler a string multipla acima
                string nome = vetor[0];
                // Como a variavel vetor está em string, precisa transformar em char
                char sexo = char.Parse(vetor[1]);
                int idade = int.Parse(vetor[2]);
                // Modo de se ultilizar CultureInfo para digitar com "."
                double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

                Console.WriteLine(n1);
                Console.WriteLine(ch);
                // Modo de se formatar uma variavel com "." e imprimir-la
                Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine(nome);
                Console.WriteLine(sexo);
                Console.WriteLine(idade);
                Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}