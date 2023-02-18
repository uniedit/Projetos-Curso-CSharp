using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_E2G_2J_Felippe
{
    internal class Program
    {
        static void Method()
        {
            double a, b, c, delta, x1, x2;
            string R;

            Console.Write("Digite A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Digite B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Digite C: ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("");

            while (delta <= 0)
            {
                Console.Write("Delta está negativo, quer digitar outros valores? ");
                R = Console.ReadLine();

                if (R == "sim")
                {
                    Console.WriteLine("");

                    Console.Write("Digite A: ");
                    a = double.Parse(Console.ReadLine());

                    Console.Write("Digite B: ");
                    b = double.Parse(Console.ReadLine());

                    Console.Write("Digite C: ");
                    c = double.Parse(Console.ReadLine());

                    delta = Math.Pow(b, 2.0) - 4.0 * a * c;

                    x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                    Console.WriteLine("");
                }
                else if (R == "nao")
                {
                    Console.WriteLine($"Delta: {delta}");
                    Console.WriteLine("");
                    break;
                }
            }

            if (delta >= 0)
            {
                // Para quebra de linha \n
                Console.WriteLine($"Delta: {delta}, x1: {x1.ToString("F2", CultureInfo.InvariantCulture)}, {x2.ToString("F2", CultureInfo.InvariantCulture)} \n");
                // Console.Read para matar mensagens no final do programa
                Console.Read();
            }
        }
    }
}
