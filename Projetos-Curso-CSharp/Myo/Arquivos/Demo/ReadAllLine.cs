using System;
using System.Diagnostics;
using System.IO;

namespace Projetos_Curso_CSharp.Myo.Arquivos.Demo {
    class ReadAllLine {
        public void Main(string[] args) {

            string path = @"C:\Users\unial\Downloads\workingWithFiles\TooMuch.txt";
            FileStream fs = null;
            StreamReader sr = null;

            var tempo = new Stopwatch();

            /*
                Tempo: 17,39 
            */

            try {
                tempo.Start();
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadToEnd();
                Console.WriteLine(line);
            } catch (IOException err) {
                Console.WriteLine($"Error: {err.Message}");
            } finally {
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
                tempo.Stop();
                Console.WriteLine($"Total time in : {tempo.Elapsed.TotalSeconds.ToString("F2")} seconds");
            }

            /*
            string path = @"c:\temp\file1.txt";
            StreamReader sr = null;
            try {
                sr = File.OpenText(path);
                while (!sr.EndOfStream) {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            } catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } finally {
                if (sr != null) sr.Close();
            }
            */

        }
    }
}
