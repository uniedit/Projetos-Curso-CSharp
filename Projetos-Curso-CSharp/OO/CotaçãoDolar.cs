using Projetos_Curso_CSharp.OO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;


namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe33 {
        internal class Class1 {
            public void Method5() {

                Console.Write("Qual é a cotação do dólar? ");
                ConversorStatic.Cotação = double.Parse(Console.ReadLine(), C.I);

                Console.Write("Quantos dólares você vai comprar? ");
                double Comprar = double.Parse(Console.ReadLine(), C.I);
                double seila = ConversorStatic.Conversor(Comprar);

                Console.WriteLine($"Valor a ser pago em reais = {seila}");

            }
        }
    }
}
