using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Vetores_e_Dados
{
    public class Classe1
    {
        internal class Class1
        {
            public void Method()
            {
                // Receber dados como (O, I, U)
                string s = Console.ReadLine();

                /* Split é declarado com "[]"
                Função Split é .Split(' ')
                OBS: Na parte em branco do (' '), ele serve para recortar o String na parte representada 
                dentro das aspas, como no exemplo, ele recorta apenas espaços em branco
                */
                String[] vetor = s.Split(' ');

                // Como o exemplo tem apenas 3 valores, o vetor vai até 2
                String p1 = vetor[0];
                String p2 = vetor[1];
                String p3 = vetor[2];

                Console.WriteLine(p1);
                Console.WriteLine(p2);
                Console.WriteLine(p3);

                // Para facilitar a leitura, é possivel se ultilizar da função Split dentro da variavel String

                string[] v = Console.ReadLine().Split(' ');

                string v0 = v[0];
                string v1 = v[1];

                Console.WriteLine(v0);
                Console.WriteLine(v1);
            }
        }
    }
}
