using Projetos_Curso_CSharp.Myo.OO.Métodos_de_Extensão.Demo.Extensions;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Métodos_de_Extensão.Demo {
    class Program {
        public void Main(string[] args) {

            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);

            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine("------------------------------");

            string s1 = "Good Moaning Dear Cookies";

            Console.WriteLine(s1.Cut(10));

        }
    }
}
