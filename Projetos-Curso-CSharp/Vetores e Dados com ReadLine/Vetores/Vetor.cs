using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe23 {
        internal class Class1 {
            public void Method3() {

                int n = int.Parse(Console.ReadLine());
                double[] vect = new double[n]; // Modo de criar uma variavel recebendo vetores

                // Criar um loop definido por "n"e receber multiplos vetores, armazenando-o em vect
                // OBS: o lugar na memoria do vetor pode ser acessado dentro de "[]"
                for (int i = 0; i < n; i++) {
                    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                double sum = 0.0;
                // Criando sum + vect <- no caso 3 vezes, defino por "n", assim é possivel ler de 0 a 2
                for (int i = 0; i < n; i++) {
                    sum += vect[i];
                }

                double avg = sum / n;

                Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            }
        }
    }
}