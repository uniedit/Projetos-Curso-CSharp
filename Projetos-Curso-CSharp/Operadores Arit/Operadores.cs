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
                /* 
                OBS: Para que não seja necessario se ultilizar do casting em uma
                variavel (como "double a = (double) 8 / 3"), que já é de ponto 
                flutuante como o (double e float) pode-se ultilizar um valor 
                com casa decimal ("double a = 10.0 / 8.0")
                
                Operadores aritmeticos padrão:
                + = Adição
                - = Subtração
                * = Multiplicação
                / = Divisão
                % = Resto da divisão
                (x % y == 0) x Multiplo de y
                Resto da divisão será util quando quer descobrir se é par ou impar e multiplo de outro ^^

                Operadores avançados
                Math.sqrt(0) < - Raiz quadrada
                Math.pow(0, 1) <- 0 elevado a 1
                */



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

                Console.WriteLine("---------");

                a = 10;
                Console.WriteLine(a);

                // 10 + 2
                a += 2;
                Console.WriteLine(a);

                // 12 * 3
                // OBS: * e % tem mais prioridade que + e -
                a *= 3;
                Console.WriteLine(a);

                Console.WriteLine("---------");

                string s = "ABC";
                Console.WriteLine(s);

                // += Tambem concatena strings
                s += "DEF";
                Console.WriteLine(s);
            }
        }
    }
}

