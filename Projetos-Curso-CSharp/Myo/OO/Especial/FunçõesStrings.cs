using System;

namespace Projetos_Curso_CSharp.Vetores_e_Dados {
    internal class FunçõesStrings {
        public void Method() {

            string original = "abcde FGHIJ ABC abc DEFG ";
            
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); // Remove espaço em branco no começo e no fim
            
            int n1 = original.IndexOf("bc"); // Procura a primeira ocorrencia de "bc"
            int n2 = original.LastIndexOf("bc"); // Procura a ultima ocorrencia de "bc"
            
            string s4 = original.Substring(3); // Vai no Index 3 e recorta ela, deletando tudo antes
            string s5 = original.Substring(3, 5); // Vai no Index 3 e recorta ela, deletando tudo antes e 5 casas depois
            string s6 = original.Replace('a', 'x'); // Substitui "a" por "x"
            string s7 = original.Replace("abc", "xy");
            
            bool b1 = String.IsNullOrEmpty(original); // Verifica se a String está Nulla ou Vazia
            bool b2 = String.IsNullOrWhiteSpace(original); // Verifica se a String está Nulla ou com espaços em Branco

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}
