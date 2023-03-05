using Projetos_Curso_CSharp.OO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;


namespace Projetos_Curso_CSharp {
    internal class Testes {
        static void Main(string[] args) {
            // Construtor de 3 parametros, inserindo 3 variaveis
            Encapsulamento x = new Encapsulamento("TV", 500.00, 10);

            // Modo de usar Set
            // x.SetNome("TV 4K");

            // Modo de usar Set Properties
            x.Nome = "TV 4K";

            // Modo de usar Get
            Console.WriteLine(x.GetNome());
            Console.WriteLine(x.GetPreco());

            // Modo de usar Get Properties
            Console.WriteLine(x.Nome);
            Console.WriteLine(x.Preco);
            Console.WriteLine(x.ValorTotalEmEstoque);


        }
    }
}