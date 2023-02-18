using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Conversão_Casting
{
    public class Classe1
    {
        internal class Class1
        {
            public void Method()
            {
                /* OBS: Para que não seja necessario se ultilizar do casting em uma
                variavel (como "double a = (double) 8 / 3"), que já é de ponto 
                flutuante como o (double e float) pode-se ultilizar um valor 
                com casa decimal ("double a = 10.0 / 8.0")
                */

                double a;
                float b;

                a = 5.1;
                // Faz com que o compilador transforme double (8 Bites) em float (4 Bites)
                b = (float)a;

                Console.WriteLine(b);

                Console.WriteLine("-----------");

                double a1;
                int b2;

                a1 = 5.1;
                // Terá uma perca de informações (.1)
                b2 = (int)a1;

                Console.WriteLine(b2);

            }
        }
    }
}
