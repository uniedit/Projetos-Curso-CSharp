using Projetos_Curso_CSharp.Myo.OO.Abstração.Métodos_Abstratos.Entities.Enums;
using Projetos_Curso_CSharp.Myo.OO.Abstração.Métodos_Abstratos.Entities;
using C = Projetos_Curso_CSharp.Global.Global;
using System.Collections.Generic;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Abstração.Métodos_Abstratos {
    class Program {
        public void Main(string[] args) {

            List<Shape> list = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++) {
                Console.WriteLine($"Shape #{i} data:");

                Console.Write("Rectangle or Circle (r/c)? ");
                char resp = char.Parse(Console.ReadLine());
                string lowerResp = resp.ToString().ToLower();

                Console.Write("Color (Black/Blue/Red): ");
                Color color = (Color) Enum.Parse(typeof(Color), Console.ReadLine());

                if (lowerResp == "r") {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), C.I);

                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), C.I);

                    list.Add(new Rectangle(width, height, color));
                } else if (lowerResp == "c") {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), C.I);

                    list.Add(new Circle(radius, color));
                }

            }

            Console.WriteLine("");
            Console.WriteLine("SHAPE AREAS:");

            foreach (Shape shape in list) {
                Console.WriteLine($"{shape.Area().ToString("F2", C.I)}");
            }

        }
    }
}
