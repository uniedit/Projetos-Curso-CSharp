using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe1 {
        internal class Class1 {
            public void Method2() {

                // Importa A, B, C da classe Triangulo, fazendo duplicar-la como X e Y
                Triangulo x, y;

                x = new Triangulo();
                y = new Triangulo();

                Console.WriteLine("Entre com as medidas do Triangulo X:");
                x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Entre com as medidas do Triangulo Y:");
                y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double p = (x.A + x.B + x.C) / 2.0;
                double AreaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

                p = (y.A + y.B + y.C) / 2.0;
                double AreaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

                Console.WriteLine($"Área de X = {AreaX.ToString("F4", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Área de Y = {AreaY.ToString("F4", CultureInfo.InvariantCulture)}");

                string Maior;

                if (AreaX > AreaY) {
                    Maior = "X";
                } else {
                    Maior = "Y";
                }

                Console.WriteLine($"Maior área: {Maior}");
            }
        }
    }
}