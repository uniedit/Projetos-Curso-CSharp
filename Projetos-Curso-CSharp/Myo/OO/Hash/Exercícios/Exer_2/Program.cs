using System.Collections.Generic;
using System.IO;
using System;

namespace Projetos_Curso_CSharp.Myo.OO.Hash.Exercícios.Exer_2 {
    class Program {
        public void Main(string[] args) {

            Dictionary<string, int> votes = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            string _name;
            int _vote = 0;
            int sum = 0;

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        _name = line[0];
                        if (votes.ContainsKey(_name)) {
                            _vote = +int.Parse(line[1]);
                            sum = _vote + votes[_name];
                            votes[_name] = sum;
                        } else {
                            _vote = int.Parse(line[1]);
                            votes[_name] = _vote;
                        }
                        //_vote = int.Parse(line[1]);
                        //if (votes.ContainsKey(_name)) {
                        //    votes[_name] += _vote;
                        //} else {
                        //    votes[_name] = _vote;
                        //}
                    }
                    foreach (var items in votes) {
                        Console.WriteLine($"{items.Key}: {items.Value}");
                    }

                }
            } catch (IOException e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}
