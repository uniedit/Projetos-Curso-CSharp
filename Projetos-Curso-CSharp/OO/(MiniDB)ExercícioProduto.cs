using Projetos_Curso_CSharp.OO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;


namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe5 {
        internal class Class1 {
            public void Method3() {


                Console.WriteLine("Entre os dados do produto:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), C.I);
                Console.Write("Quantidade em estoque: ");
                int quantidade = int.Parse(Console.ReadLine(), C.I);
                Console.WriteLine();

                // Construtor padrão recebendo nome, preco, quantidade
                Produto x1 = new Produto(nome, preco, quantidade);

                // Construtor padrão sem receber variaveis
                Produto x = new Produto();

                // Construtor com variaveis pré-determinadas
                Produto x2 = new Produto() {
                    Nome = "TV",
                    Preco = 500.00,
                    Quantidade = 20
                };


                // Uso do ToString usado e formatado na class Produto
                Console.WriteLine($"Dados do Produto {x} \n");

                Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                // Para modificar algo já existente precisa primeiro declarar a variavel que vai ser usada
                int AddProd = int.Parse(Console.ReadLine());
                // Depois se usa a variavel criada na função
                x.AdicionarProdutos(AddProd);

                Console.WriteLine();
                Console.WriteLine($"Dados atualizados: {x} \n");

                Console.Write("Digite o número de produtos a ser removido do estoque: ");
                AddProd = int.Parse(Console.ReadLine());
                x.RemoverProdutos(AddProd);

                Console.WriteLine();
                Console.WriteLine($"Dados atualizados: {x}");
                Console.ReadLine();
            }
        }
    }
}
