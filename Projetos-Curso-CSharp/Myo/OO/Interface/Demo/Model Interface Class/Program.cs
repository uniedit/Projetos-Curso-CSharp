using Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelInterfaceClass.Entities;
using Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelInterfaceClass.Enums;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelInterfaceClass {
    class Program {
        public void Main(string[] args) {

            IShape s1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
