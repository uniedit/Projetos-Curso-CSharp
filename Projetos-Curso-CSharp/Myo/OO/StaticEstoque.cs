using Projetos_Curso_CSharp.Myo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class ClassTree {
        public void Method() {

            int qte;

            Console.WriteLine("Entre os dados do produto:");
            Console.Write($"Nome: ");
            StaticEstoque.Nome = Console.ReadLine();
            Console.Write($"Preço: ");
            StaticEstoque.Preco = double.Parse(Console.ReadLine(), C.I);
            Console.Write($"Quantidade no estoque: ");
            StaticEstoque.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {StaticEstoque.Nome}, $ {StaticEstoque.Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" {StaticEstoque.Quantidade} unidades, Total: {StaticEstoque.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write($"Digite o número de produtos a ser adicionado ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            StaticEstoque.AdicionarProdutos(qte);

            Console.WriteLine($"{StaticEstoque.ToString()}");

            Console.Write($"Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            StaticEstoque.RemoverProdutos(qte);

            Console.WriteLine($"{StaticEstoque.ToString()}");

        }
    }
}

