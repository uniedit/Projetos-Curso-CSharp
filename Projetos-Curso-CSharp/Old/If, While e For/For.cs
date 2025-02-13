using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ex_E2G_2J_Felippe {
    internal class Class1 {
        static void Method1() {

            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int Soma = 0;

            // Estrutura usavel quando sabe previamente quantos numeros vai repetir
            for (int M = 1; M <= N; M++) {

                Console.Write($"Valor #{M}: ");
                int Valor = int.Parse(Console.ReadLine());

                Soma += Valor;
            }

            Console.WriteLine($"Soma = {Soma}");
        }
    }
}
