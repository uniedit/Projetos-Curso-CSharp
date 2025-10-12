using System;
using System.Collections.Generic;
using System.IO;

namespace Projetos_Curso_CSharp.Myo.Arquivos.Demo {
    class directory {
        public void Main(string[] args) {

            string sourcePath = @"C:\Users\unial\Downloads\workingWithFiles";

            try {
                IEnumerable<string> folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach (string foldo in folders) {
                    Console.WriteLine(foldo);
                }

                Console.WriteLine("");

                IEnumerable<string> files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string foldo in files) {
                    Console.WriteLine(foldo);
                }

                Console.WriteLine("");

                if (!Directory.Exists(sourcePath + @"\Hollow")) {
                    Console.WriteLine("Created!!");
                    Directory.CreateDirectory(sourcePath + @"\Hollow");
                } else {
                    Console.WriteLine("This shit already exists. Kys!");
                }

            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
