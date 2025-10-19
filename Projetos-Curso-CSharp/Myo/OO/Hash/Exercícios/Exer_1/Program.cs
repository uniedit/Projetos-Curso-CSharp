using Projetos_Curso_CSharp.Myo.OO.Hash.Exercícios.Exer_1.Entities;
using System.Collections.Generic;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Hash.Exercícios.Exer_1 {
    class Program {
        public void Main(string[] args) {

            HashSet<Students> students = new HashSet<Students>();

            Console.Write("How many students for course A? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++) {
                int uniqueCode = int.Parse(Console.ReadLine());
                students.Add(new Students() {
                    UniqueCode = uniqueCode
                });
            }

            Console.Write("How many students for course B? ");
            qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++) {
                int uniqueCode = int.Parse(Console.ReadLine());
                students.Add(new Students() {
                    UniqueCode = uniqueCode
                });
            }

            Console.Write("How many students for course C? ");
            qtd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtd; i++) {
                int uniqueCode = int.Parse(Console.ReadLine());
                students.Add(new Students() {
                    UniqueCode = uniqueCode
                });
            }

            Console.WriteLine($"Total students: {students.Count}");

        }
    }
}
