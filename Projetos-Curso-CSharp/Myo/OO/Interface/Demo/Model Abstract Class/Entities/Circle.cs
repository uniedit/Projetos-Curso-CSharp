using System;
using System.Globalization;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelAbstractClass.Entities {
    // Modo para que elas "Herdem" os atributos e metodos da classe Abstrata
    class Circle : Shape {
        
        public double Radius { get; set; }

        // Para que de override no metodo abstrato
        public override double Area() {
            return Math.PI * Radius * Radius;
        }

        public override string ToString() {
            return "Circle color = "
                + Color
                + ", radius = "
                + Radius.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
