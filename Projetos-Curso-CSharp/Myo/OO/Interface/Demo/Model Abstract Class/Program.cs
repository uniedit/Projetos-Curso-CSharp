using Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelAbstractClass.Entities;
using Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelAbstractClass.Enums;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelAbstractClass {
    class Program {
        public void Main(string[] args) {

            // Modo alternativo de declarar a classe e seus atributos SEM CONSTRUTOR
            Shape s1 = new Circle() {
                Radius = 2.0,
                Color = Color.White
            };

            Shape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.White };
            
            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
