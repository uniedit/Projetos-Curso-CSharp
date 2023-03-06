using Projetos_Curso_CSharp.OO.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C = Projetos_Curso_CSharp.Global.Global;


namespace Projetos_Curso_CSharp.Vetores_e_Dados_com_ReadLine {
    public class Classe88 {
        internal class Class1 {
            public void Method() {

                Console.Write("Entre o número da conta: ");
                string y = Console.ReadLine();
                string titular = Console.ReadLine();

                ContaBancaria x = new ContaBancaria(y, titular);

                Console.WriteLine(x.TitularConta + x.NumeroConta);


            }
        }
    }
}