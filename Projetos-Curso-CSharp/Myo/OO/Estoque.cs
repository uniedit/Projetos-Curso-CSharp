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
            Estoque.Nome = Console.ReadLine();
            Console.Write($"Preço: ");
            Estoque.Preco = double.Parse(Console.ReadLine(), C.I);
            Console.Write($"Quantidade no estoque: ");
            Estoque.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {Estoque.Nome}, $ {Estoque.Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" {Estoque.Quantidade} unidades, Total: {Estoque.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write($"Digite o número de produtos a ser adicionado ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            Estoque.AdicionarProdutos(qte);

            Console.WriteLine($"{Estoque.ToString()}");

            Console.Write($"Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            Estoque.RemoverProdutos(qte);

            Console.WriteLine($"{Estoque.ToString()}");

        }
    }
}

