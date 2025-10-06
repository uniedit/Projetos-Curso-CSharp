using Projetos_Curso_CSharp.Myo.OO.Abstração.Métodos_Abstratos.Entities.Enums;

namespace Projetos_Curso_CSharp.Myo.OO.Abstração.Métodos_Abstratos.Entities {
    abstract class Shape {

        public Color Color { get; set; }

        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();

    }
}
