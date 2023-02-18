using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine
{
    public class Classe3
    {
        internal class Class1
        {
            public void Method()
            {
                Console.WriteLine("Entre com seu nome completo:");
                string nome = Console.ReadLine();

                Console.WriteLine("Quantos quartos tem na sua casa?");
                int quartos = int.Parse(Console.ReadLine());

                Console.WriteLine("Entre com o preço de um produto:");
                double prod = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Entre seu ultimo nome, idade e alture (mesma linha):");
                string[] vet = Console.ReadLine().Split(' ');

                Console.WriteLine(nome);
                Console.WriteLine(quartos);
                Console.WriteLine(prod.ToString("F2", CultureInfo.InvariantCulture));

                string n1 = vet[0];
                int n2 = int.Parse(vet[1]);
                double n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                Console.WriteLine(n1);
                Console.WriteLine(n2);
                Console.WriteLine(n3.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
