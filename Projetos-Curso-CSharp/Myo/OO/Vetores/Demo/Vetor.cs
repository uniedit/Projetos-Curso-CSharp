using System;
using C = Projetos_Curso_CSharp.Global.Global;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo {
    internal class Class {
        public void Method() {

            int n = int.Parse(Console.ReadLine());

            /* Vetor com double + nome do vetor
            + new double (criar um vetor double) 
            + n (tamanho do vetor) */

            // PS: Vetor com um struct (double)
            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), C.I);
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                soma += vect[i];
            }

            double media = soma / n;
            Console.WriteLine(media.ToString("F2", C.I));

        }
    }
}
