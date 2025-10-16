using System;

namespace Projetos_Curso_CSharp.Myo.OO.Generics.Demo.Sem_Restrição {
    class Program {
        public void Main(string[] args) {

            // Definindo o tipo da variavel que o Generic vai receber
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("First: " + printService.First());

        }
    }
}
