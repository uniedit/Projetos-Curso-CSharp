using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe.Template
{
    public class Comparativas
    {
        internal class Class1
        {
            public void Method2()
            {
                int a = 10;

                // a é maior ou igual a 10?
                bool c1 = a <= 10;

                // a é exatamente igual a 10?
                bool c2 = a == 10;

                // a é diferente de 10?
                bool c3 = a != 10;

                Console.WriteLine(c1);
                Console.WriteLine(c2);
                Console.WriteLine(c3);
            }
        }
    }
}
