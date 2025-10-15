using System.Globalization;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelAbstractClass.Entities {
    // Modo para que elas "Herdem" os atributos e metodos da classe Abstrata
    class Rectangle : Shape {
        
        public double Width { get; set; }
        public double Height { get; set; }

        // Para que de override no metodo abstrato
        public override double Area() {
            return Width * Height;
        }

        public override string ToString() {
            return "Rectangle color = "
                + Color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
