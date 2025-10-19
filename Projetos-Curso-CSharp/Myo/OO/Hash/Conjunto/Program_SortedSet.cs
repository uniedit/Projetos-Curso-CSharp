using System.Collections.Generic;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Hash.Conjunto {
    class Program_SortedSet {
        public void Main(string[] args) {

            // Declarar um SortedSet
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            // Fazendo a união de a com b. No caso não repetindo nenhum valor
            c.UnionWith(b);
            printCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            // Fazendo a intersecção com b. No caso pegando todos os valores que são iguais nas duas coleções
            d.IntersectWith(b);
            printCollection(d);

            //difference
            SortedSet<int> e = new SortedSet<int>(a);
            // Fazendo a diferença com b
            e.ExceptWith(b);
            printCollection(e);
        }

        // Metodo para imprimir uma coleção usando o IEnumerable, uma vez que o mesmo
        // está em todos objetos do System.Collections.
        // Além de usar um generic para pegar qualquer tipo de dado (qualquer coleção)
        static void printCollection<Generic>(IEnumerable<Generic> collection) {
            foreach (Generic obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}
