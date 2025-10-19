using Projetos_Curso_CSharp.Myo.OO.Hash.GetHashCode_e_Equals.Entities;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Hash.GetHashCode_e_Equals {
    class Program {
        public void Main(string[] args) {

            Client a = new Client() { Name = "Haiii", Email = "haii@gmail.com" };
            Client b = new Client() { Name = "Huh?", Email = "huhhh@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

        }
    }
}
