using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe2 {
        internal class Class1 {
            public void Method2() {

                Console.Write("Digite seu Nome, Idade, Peso e Altura: ");
                string[] vetor = Console.ReadLine().Split(' ');

                string nome = (vetor[0]);
                int idade = int.Parse(vetor[1]);
                double peso = double.Parse(vetor[2], CultureInfo.InvariantCulture);
                double altura = double.Parse(vetor[3], CultureInfo.InvariantCulture);

                double IMC = (double)peso / (altura * altura);

                if (IMC < 16) {
                    Console.WriteLine($"{nome} está com 'Magreza'");
                    Console.Read();
                } else if (IMC == 16 || IMC < 17) {
                    Console.WriteLine($"{nome} está com 'Magreza moderada'");
                    Console.Read();
                } else if (IMC == 17 || IMC < 18.5) {
                    Console.WriteLine($"{nome} está com 'Magreza leve'");
                    Console.Read();
                } else if (IMC == 18.5 || IMC < 25) {
                    Console.WriteLine($"{nome} está Saudável!!");
                    Console.Read();
                } else if (IMC == 25 || IMC < 30) {
                    Console.WriteLine($"{nome} está com 'Sobrepeso'");
                    Console.Read();
                } else if (IMC == 30 || IMC < 35) {
                    Console.WriteLine($"{nome} está com 'Obesidade Grau I'");
                    Console.Read();
                } else if (IMC == 35 || IMC < 40) {
                    Console.WriteLine($"{nome} está com 'Obesidade Grau II (considerada severa)'");
                    Console.Read();
                } else if (IMC > 40) {
                    Console.WriteLine($"{nome} está com 'Obesidade Grau II (considerada mórbida)'");
                    Console.Read();
                }

            }
        }
    }
}