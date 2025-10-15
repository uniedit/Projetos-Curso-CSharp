using Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelAbstractClass.Enums;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelAbstractClass.Entities {
    // Usando uma classe Abstrata para fazer com que Circle e Rectangle "Herdem" esses atributos
    abstract class Shape {

        public Color Color { get; set; }
        
        // Jeito de declarar um metodo Abstrato
        public abstract double Area();

    }
}
