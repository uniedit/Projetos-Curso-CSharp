using Projetos_Curso_CSharp.Myo.OO.Abstração.Métodos_Abstratos.Entities.Enums;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Abstração.Métodos_Abstratos.Entities {
    class Circle : Shape {

        public double Radius { get; set; }

        public Circle(double radius, Color color) 
            : base (color) {
            Radius = radius;
        }

        public override double Area() {
            return (Radius * Radius) * Math.PI;
        }

    }
}
