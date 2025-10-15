using Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Comparação_X_IComparable.Entities;
using System.Collections.Generic;
using System.IO;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Comparação_X_IComparable {
    class ProgramWithIComparable {
        public void Main(string[] args) {

            string path = @"C:\Users\unial\Downloads\workingWithFiles\Hollow\in\inSal.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream) {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list) {
                        Console.WriteLine(emp);
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
