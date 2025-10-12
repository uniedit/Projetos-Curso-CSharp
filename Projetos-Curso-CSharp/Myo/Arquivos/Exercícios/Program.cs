using System;
using System.IO;
using C = Projetos_Curso_CSharp.Global.Global;
using Projetos_Curso_CSharp.Myo.Arquivos.Exercícios.Entities;

namespace Projetos_Curso_CSharp.Myo.Arquivos.Exercícios {
     class Program {
        public void Main(string[] args) {

            Console.WriteLine("Digite o caminho do arquivo:");
            string path = Console.ReadLine();

            string targetPath = path + @"\Out";

            string targetExtension = ".csv";

            var sourceFile = Directory.GetFiles(path, "*" + targetExtension);

            var targetFile = targetPath + @"\summary" + targetExtension;

            if (!Directory.Exists(targetPath)) {
                Directory.CreateDirectory(targetPath);
                Console.WriteLine("Directory Created With Success.");
            } else {
                Console.WriteLine("Directory Already Exists.");
            }

            if (!File.Exists(targetFile)) {
                using (File.Create(targetFile)) { }
                Console.WriteLine("File Created With Success.");
            } else {
                Console.WriteLine("File Already Exists.");
            }

            try {
                using (FileStream fs = new FileStream(sourceFile[0], FileMode.Open)) {
                    using (StreamReader sr = new StreamReader(fs)) {
                        using (StreamWriter sw = new StreamWriter(targetFile)) {
                            while (!sr.EndOfStream) {
                                string lines = sr.ReadLine();
                                string[] infos = lines.Split(',');

                                string name = infos[0];
                                double price = double.Parse(infos[1], C.I);
                                int qtd = int.Parse(infos[2]);

                                Product product = new Product(name, price, qtd);

                                product.Total();

                                sw.Write(product);
                                if (!sr.EndOfStream) {
                                    sw.Write('\n');
                                }
                            }

                        }
                    }
                }
            } catch (IOException err) {
                Console.WriteLine($"Error: {err.Message}");
            }

            try {
                using (FileStream fs = new FileStream(targetFile, FileMode.Open)) {
                    using (StreamReader sr = new StreamReader(fs)) {
                        Console.WriteLine("File Infos Updated With Success.\n");
                        Console.WriteLine("Updated Infos:");
                        string line = sr.ReadToEnd();
                        Console.WriteLine(line);
                    }
                }
            } catch (IOException err) {
                Console.WriteLine($"Error: {err.Message}");
            }

        }
    }
}
