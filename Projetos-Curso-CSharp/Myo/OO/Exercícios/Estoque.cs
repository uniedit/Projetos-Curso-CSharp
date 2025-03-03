using Projetos_Curso_CSharp.Myo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class ClassFor {
        public void Method() {

            int qte;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write($"Nome: ");
            string Nome = Console.ReadLine();
            Console.Write($"Preço: ");
            double Preco = double.Parse(Console.ReadLine(), C.I);
            Console.Write($"Quantidade no estoque: ");
            int Quantidade = int.Parse(Console.ReadLine());

            // Estoque estoque = new Estoque("Teste", 999.99, 999);
            Estoque estoque = new Estoque(Nome, Preco, Quantidade);

            Console.WriteLine($"Dados do produto: {estoque.Nome}, $ {estoque.Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" {estoque.Quantidade} unidades, Total: {estoque.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write($"Digite o número de produtos a ser adicionado ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            estoque.AdicionarProdutos(qte);

            Console.WriteLine($"{estoque}");

            Console.Write($"Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            estoque.RemoverProdutos(qte);

            Console.WriteLine($"{estoque}");

        }
    }
}

