using System;
using System.IO;

namespace Projetos_Curso_CSharp.Myo.Arquivos.Demo {
    class StreamWritter {
        public void Main(string[] args) {

            string sourcePath = @"C:\Users\unial\Downloads\workingWithFiles\fileOne.txt";
            string targetPath = @"C:\Users\unial\Downloads\workingWithFiles\fileOneCopying.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = new StreamWriter(targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine(line.ToLower());
                    }
                }

            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
