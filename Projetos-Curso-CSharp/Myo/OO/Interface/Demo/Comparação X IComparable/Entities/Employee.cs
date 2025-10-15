using System;
using System.Globalization;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.Comparação_X_IComparable.Entities {

    // Para que o Programa consiga utilizar o "sort" de maneira adequada numa lista onde
    // a mesma possui dois tipos de dados, "Name", "Salary" precisamos do IComparable
    class Employee : IComparable {

        // Implementando os atributos
        public string Name { get; set; }
        public double Salary { get; set; }

        /*
            Usando o construtor do programa para quebrar o que for lido no arquivo em um vetor
            onde o mesmo vai-se utilizar de um Split. 
            Assim alocando a primeira posição para o Name e a segunda para o Salary 
        */

        public Employee(string csvEmployee) {
            string[] vect = csvEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString() {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        // Metodo herdado do IComparable para que ele consiga identificar mais de um dado na Lista
        public int CompareTo(object obj) {
            // Apenas verificação para que o "obj" sejá sempre a classe "Employee"
            if (!(obj is Employee)) {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }

            // Fazendo downcasting de obj para Employee eu acho
            Employee other = obj as Employee;

            /*
                Aqui onde define o que o IComparable vai fazer, no caso ele vai retornar
                apenas o "Name", assim filtrando ele por ordem alfabetica, já que o objeto
                string tem o IComparable.

                Caso fosse com o objeto double, ele colocaria em ordem crescente de valor.
            */

            return Name.CompareTo(other.Name);
        }

    }
}
