using System.Collections.Generic;
using System.Linq;
using System;

namespace Projetos_Curso_CSharp.Myo.Funcional.Linq.Demo {
    class Program {
        public void Main(string[] args) {

            // Referencia para operações com Linq
            // https://www.udemy.com/course/programacao-orientada-a-objetos-csharp/learn/lecture/11444486#overview

            int[] numbers = { 1, 2, 3, 4, 6 };

            // var result = IEnumerable já que ele é uma interface generica
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0) // Where para filtrar os elementos do vetor
                .Select(x => x * 10); // Select para aplicar nesses elementos alguma expressão

            // Força a consulta usando o Linq
            foreach (int x in result) {
                Console.WriteLine(x);
            }

        }
    }
}
