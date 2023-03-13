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

            double insano = 1.69;
            Console.WriteLine($"Hi são seço {insano.ToString("F", C.I)}\n");

        }
    }
}