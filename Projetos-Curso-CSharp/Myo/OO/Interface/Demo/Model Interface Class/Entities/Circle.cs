using System;
using System.Globalization;

namespace Projetos_Curso_CSharp.Myo.OO.Interface.Demo.ModelInterfaceClass.Entities {
    // "Herdando" da classe Abstrata ponte AbstractShape
    class Circle : AbstractShape {

        public double Radius { get; set; }
        
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
