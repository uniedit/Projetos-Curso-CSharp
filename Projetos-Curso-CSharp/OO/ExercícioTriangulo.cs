using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;


namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe1 {
        internal class Class1 {
            public void Method2() {

                // Importa A, B, C da classe Triangulo, fazendo duplicar-la como X e Y
                Triangulo x, y;

                x = new Triangulo();
                y = new Triangulo();

                Console.WriteLine("Entre com as medidas do Triangulo X:");
                x.A = double.Parse(Console.ReadLine(), C.I);
                x.B = double.Parse(Console.ReadLine(), C.I);
                x.C = double.Parse(Console.ReadLine(), C.I);

                Console.WriteLine("Entre com as medidas do Triangulo Y:");
                y.A = double.Parse(Console.ReadLine(), C.I);
                y.B = double.Parse(Console.ReadLine(), C.I);
                y.C = double.Parse(Console.ReadLine(), C.I);

                double AreaX = x.Area();
                double AreaY = y.Area();

                Console.WriteLine($"Área de X = {AreaX.ToString("F4", C.I)}");
                Console.WriteLine($"Área de Y = {AreaY.ToString("F4", C.I)}");

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