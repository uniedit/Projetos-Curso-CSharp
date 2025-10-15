using Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelInterfaceClass.Enums;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelInterfaceClass.Entities {
    // Classe "Ponte" entre a Interface IShape e uma classe Abstrata
    abstract class AbstractShape : IShape {
        
        public Color Color { get; set; }

        // Modo que a classe abstrata pode "herdar" de uma interface seus metodos/atributos
        public abstract double Area();

    }
}
