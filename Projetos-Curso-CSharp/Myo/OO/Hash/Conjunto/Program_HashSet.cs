using System.Collections.Generic;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Hash.Conjunto {
    class Program_HashSet {
        public void Main(string[] args) {

            HashSet<string> set = new HashSet<string>();

            set.Add("a");
            set.Add("b");
            set.Add("c");
            set.Add("d");
            set.Add("e");
            set.Add("f");
            set.Add("g");
            set.Add("h");
            set.Add("i");

            foreach (string p in set) {
                Console.WriteLine(p);
            }

        }
    }
}
