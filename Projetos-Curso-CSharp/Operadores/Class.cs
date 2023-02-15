using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe.Template
{
    public class Classe1
    {
        internal class Class1
        {
            public void Method()
            {
                int a = 10;
                a++;
                Console.WriteLine(a);

                Console.WriteLine("---------");

                /* a++ adiciona +1 a variavel
                OBS: quando usada para atribuir valor de algo, ela atribui o valor, depois conta como variavel
                por isso cw(10) e cw(11)
                */

                int a1 = 10;
                int b1 = a1++;

                Console.WriteLine(a1);
                Console.WriteLine(b1);

                Console.WriteLine("---------");

                // aqui a operação se inverte apenas
                // cw(11) e cw(11)

                int a2 = 10;
                int b2 = ++a2;

                Console.WriteLine(a2);
                Console.WriteLine(b2);
            }
        }
    }
}

