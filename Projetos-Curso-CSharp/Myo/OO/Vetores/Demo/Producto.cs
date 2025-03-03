using System;
using Projetos_Curso_CSharp.Myo.OO.Vetores.Demo.Entities;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo {
    internal class Class2 {
        public void Method() {

            Console.Write("Digite a Quantidade de Produtos desejada: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\n");

            /* Tipo do vetor (objetos tipo referencia) + nome do vetor
            + new Tipo do vetor (objetos tipo referencia)
            + n (tamanho do vetor) */

            // PS: Vetor agora com uma classe
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++) {
                Console.Write($"Digite o Nome do {i + 1}º Produto: ");
                string name = Console.ReadLine();
                Console.Write($"Digite o Preço do {i + 1}º Produto: ");
                double price = double.Parse(Console.ReadLine(), C.I);
                Console.Write("\n");

                // Dentro de um tipo classem, a sintaxe para atribuir valores é diferente
                // Assim precisando de uma instanciação de construtor padrão (get, set)
                vect[i] = new Product { Nome = name, Preço = price };
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                soma += vect[i].Preço;
            }

            double media = soma / n;

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Nome do {i + 1}º Produto: " + vect[i].Nome);
            }
            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Preço do {i + 1}º Produto: " + vect[i].Preço.ToString("F2", C.I));
            }

            Console.Write("\n");
            Console.WriteLine("Media dos Produtos: " + media.ToString("F2", C.I));

        }
    }
}


