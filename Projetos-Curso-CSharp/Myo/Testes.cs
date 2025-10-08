using C = Projetos_Curso_CSharp.Global.Global;
using System;

namespace Projetos_Curso_CSharp {
    class Testes {
        static void Main(string[] args) {

            double insano = 1.69;
            Console.WriteLine($"Hi\nTyler!! {insano.ToString("F", C.I)}");

        }
    }
}