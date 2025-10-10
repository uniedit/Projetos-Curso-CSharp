using System;
using System.IO;

namespace Projetos_Curso_CSharp.Myo.Arquivos.Demo {
    class ReadFirstLine {
        public void Main(string[] args) {

            string path = @"C:\Users\unial\Downloads\workingWithFiles\fileOne.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            } catch (IOException err) {
                Console.WriteLine($"Error: {err.Message}");
            } finally {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }

        }
    }
}
