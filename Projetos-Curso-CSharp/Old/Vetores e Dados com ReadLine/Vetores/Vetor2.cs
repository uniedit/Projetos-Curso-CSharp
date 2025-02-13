using Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine.Vetores.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe77 {
        internal class Class1 {
            public void Method7() {

                int n = int.Parse(Console.ReadLine());
                Produto[] vect = new Produto[n];

                for (int i = 0; i < n; i++) {
                    string name = Console.ReadLine();
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    // Cria duas variaveis para armazenar dois tipos dentro de uma caixa de vetor
                    vect[i] = new Produto { Name = name, Price = price }; // << modo de colocar duas caixa em um vetor usando get 
                }

                double sum = 0.0;
                for (int i = 0; i < n; i++) {
                    sum += vect[i].Price;
                }
                double avg = sum / n;

                Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}
