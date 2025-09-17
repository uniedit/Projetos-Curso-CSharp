using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos_Curso_CSharp.Myo.OO.Vetores.Demo {
    internal class Class4 {
        public void Method() {

            List<string> list1 = new List<string>();

            // Adiciona ao final da Lista.
            list1.Add("Nao Manitooo");
            list1.Add("Maniiiiiii");
            list1.Add("tooooooooo");

            foreach (string obj in list1) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------");

            list1.Add("Manitoooo");

            foreach (string obj in list1) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------");

            // Especifica a posição
            list1.Insert(0, "Naoooo");

            foreach (string obj in list1) {
                Console.WriteLine(obj);
            }

            // Contador da Lista
            Console.WriteLine("Tamanho da Lista: " + list1.Count);

            Console.WriteLine("-----------");

            // Encontrar a Primeira Ocorrencia de Algo
            string x1 = list1.Find(x => x[0] == 'N');
            Console.WriteLine("Primeiro 'N' é: " + x1);

            // Encontrar a Ultima Ocorrencia de Algo
            string x2 = list1.FindLast(x => x[0] == 'N');
            Console.WriteLine("Ultimo 'N' é: " + x2);

            // Encontrar a Primeira Posição de algo
            int y1 = list1.FindIndex(x => x[0] == 'N');
            Console.WriteLine("Primeira Posição 'N' é: " + y1);

            //Encontrar a Ultima Posição de algo
            int y2 = list1.FindLastIndex(x => x[0] == 'N');
            Console.WriteLine("Ultima Posição 'N' é: " + y2);

            Console.WriteLine("-----------");

            // Encontrar na Lista todos os elementos que Satisfaçam a condição (Predicado)
            List<string> result1 = list1.FindAll(x => x.Length == 5);
            List<string> result2 = list1.FindAll(x => x.Length > 4);

            foreach (string obj in result1) {
                Console.WriteLine("Igual a 5: " + obj);
            }

            foreach (string obj in result2) {
                Console.WriteLine("Maior que 4: " + obj);
            }

            Console.WriteLine("-----------");

            // Remover na Lista algo
            list1.Remove("Naoooo");

            // Remove tudo na Lista que Satisfaça a condição (Predicado)
            list1.RemoveAll(x => x[0] == 't');

            foreach (string obj in list1) {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-----------");

            // Remove na Posição Especifica
            list1.RemoveAt(2);

            // Remove de uma Posição Especifica, porém até outra Posição
            list1.RemoveRange(1, 1);

            foreach (string obj in list1) {
                Console.WriteLine(obj);
            }

        }
    }
}
